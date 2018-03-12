namespace Eighty.Test.WebApp.Models
{
    public class BenchModel
    {
        public int Iterations { get; }
        public string ClassName { get; }

        public BenchModel(int iterations, string className)
        {
            Iterations = iterations;
            ClassName = className;
        }
    }
}