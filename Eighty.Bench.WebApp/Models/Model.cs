namespace Eighty.Bench.WebApp.Models
{
    public class Model
    {
        public int Iterations { get; }
        public string ClassName { get; }

        public Model(int iterations, string className)
        {
            Iterations = iterations;
            ClassName = className;
        }
    }
}