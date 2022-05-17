using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

namespace Eighty.Bench
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SimpleBench>();
            BenchmarkRunner.Run<WebAppBench>();
        }
    }
}
