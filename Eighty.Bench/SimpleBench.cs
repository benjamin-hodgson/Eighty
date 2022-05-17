using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using Eighty.Twenty;

using static Eighty.Html;

namespace Eighty.Bench;

[MemoryDiagnoser, GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class SimpleBench
{
    private Html _flatPsEighty;
    private Html _deepPsEighty;
    private HtmlBuilder _flatPsTwenty;
    private HtmlBuilder _deepPsTwenty;

    [GlobalSetup]
    public void Setup()
    {
        _flatPsEighty = _(Enumerable.Repeat(p(@class: "para<>")._(), 1000));
        _deepPsEighty = DeepPs(1000);
        _flatPsTwenty = new FlatPs();
        _deepPsTwenty = new DeepPs();
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        File.Delete("output.html");
    }

    [BenchmarkCategory("Flat"), Benchmark]
    public void Flat_Eighty_BuildAndRender()
    {
        var html = p(@class: "para<>")._();
        var builder = ImmutableArray.CreateBuilder<Html>(1000);
        for (var _ = 0; _ < 1000; _++)
        {
            builder.Add(html);
        }
        using (var writer = new StreamWriter("output.html"))
        {
            _(builder.MoveToImmutable()).Write(writer);
        }
    }

    [BenchmarkCategory("Flat"), Benchmark(Baseline = true)]
    public void Flat_Eighty_BuildAndRender_NoSharing()
    {
        var builder = ImmutableArray.CreateBuilder<Html>(1000);
        for (var _ = 0; _ < 1000; _++)
        {
            builder.Add(p(@class: "para<>")._());
        }
        using (var writer = new StreamWriter("output.html"))
        {
            _(builder.MoveToImmutable()).Write(writer);
        }
    }

    [BenchmarkCategory("Flat"), Benchmark]
    public void Flat_Eighty_Render()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            _flatPsEighty.Write(writer);
        }
    }

    [BenchmarkCategory("Flat"), Benchmark]
    public async Task Flat_Eighty_RenderAsync()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            await _flatPsEighty.WriteAsync(writer);
        }
    }

    [BenchmarkCategory("Flat"), Benchmark]
    public void Flat_Twenty()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            _flatPsTwenty.Write(writer);
        }
    }

    [BenchmarkCategory("Deep"), Benchmark(Baseline = true)]
    public void Deep_Eighty_BuildAndRender()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            DeepPs(1000).Write(writer);
        }
    }

    [BenchmarkCategory("Deep"), Benchmark]
    public void Deep_Eighty_Render()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            _deepPsEighty.Write(writer);
        }
    }

    [BenchmarkCategory("Deep"), Benchmark]
    public async Task Deep_Eighty_RenderAsync()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            await _deepPsEighty.WriteAsync(writer);
        }
    }

    [BenchmarkCategory("Deep"), Benchmark]
    public void Deep_Twenty()
    {
        using (var writer = new StreamWriter("output.html"))
        {
            _deepPsTwenty.Write(writer);
        }
    }

    private Html DeepPs(int lvl)
        => lvl == 0
            ? Text("")
            : p(@class: "para<>")._(DeepPs(lvl - 1));
}
