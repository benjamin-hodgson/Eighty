using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Engines;
using Eighty.Twenty;
using static Eighty.Html;

namespace Eighty.Bench
{
    [MemoryDiagnoser]
    public class SimpleBench
    {
        private Html _flatPsEighty;
        private Html _deepPsEighty;
        private HtmlBuilder _flatPsTwenty;
        private HtmlBuilder _deepPsTwenty;

        [GlobalSetup]
        public void Setup()
        {
            _flatPsEighty = _(Enumerable.Repeat(p(@class: "para")._(), 1000));
            _deepPsEighty = DeepPs(1000);
            _flatPsTwenty = new FlatPs();
            _deepPsTwenty = new DeepPs();
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            File.Delete("output.html");
        }

        [Benchmark]
        public void Flat_Eighty_BuildAndRender()
        {
            var html = p(@class: "para<>")._();
            var builder = ImmutableArray.CreateBuilder<Html>(1000);
            for (var _ = 0; _ < 1000; _++)
            {
                builder.Add(html);
            }
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _(builder.MoveToImmutable()).Write(writer);
            }
        }

        [Benchmark]
        public void Flat_Eighty_BuildAndRender_NoSharing()
        {
            var builder = ImmutableArray.CreateBuilder<Html>(1000);
            for (var _ = 0; _ < 1000; _++)
            {
                builder.Add(p(@class: "para<>")._());
            }
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _(builder.MoveToImmutable()).Write(writer);
            }
        }
        
        [Benchmark]
        public void Flat_Eighty_Render()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _flatPsEighty.Write(writer);
            }
        }
        
        [Benchmark]
        public async Task Flat_Eighty_RenderAsync()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                await _flatPsEighty.WriteAsync(writer);
            }
        }
        
        [Benchmark]
        public void Flat_Twenty()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _flatPsTwenty.Write(writer);
                writer.ToString();
            }
        }

        [Benchmark]
        public void Deep_Eighty_BuildAndRender()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                DeepPs(1000).Write(writer);
            }
        }
        
        [Benchmark]
        public void Deep_Eighty_Render()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _deepPsEighty.Write(writer);
            }
        }
        
        [Benchmark]
        public async Task Deep_Eighty_RenderAsync()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                await _deepPsEighty.WriteAsync(writer);
            }
        }
        
        [Benchmark]
        public void Deep_Twenty()
        {
            using (var stream = File.OpenWrite("output.html"))
            using (var writer = new StreamWriter(stream))
            {
                _deepPsTwenty.Write(writer);
                writer.ToString();
            }
        }

        private Html DeepPs(int lvl)
            => lvl == 0
                ? Text("")
                : p(@class: "para<>")._(DeepPs(lvl-1));
    }
}
