using BenchmarkDotNet.Running;

#pragma warning disable CS0436 // Type conflicts with imported type
BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAllJoined();
#pragma warning restore CS0436 // Type conflicts with imported type
