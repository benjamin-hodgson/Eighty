using Eighty.Twenty;

namespace Eighty.Bench
{
    public class DeepPs : HtmlBuilder
    {
        protected override void Build()
        {
            _DeepPs(1000);
        }

        private void _DeepPs(int lvl)
        {
            if (lvl == 0)
            {
                return;
            }
            using (p(@class: "para<>"))
            {
                _DeepPs(lvl-1);
            }
        }
    }
}
