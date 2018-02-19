using Eighty.Twenty;

namespace Eighty.Bench
{
    public class FlatPs : HtmlBuilder
    {
        protected override void Build()
        {
            for (var i = 0; i < 1000; i++)
            {
                using (p(@class: "para<>")) { }
            }
        }
    }
}
