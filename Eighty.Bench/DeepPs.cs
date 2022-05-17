using Eighty.Twenty;

namespace Eighty.Bench;

public class DeepPs : HtmlBuilder
{
    protected override void Build()
    {
        Go(1000);
    }

    private void Go(int lvl)
    {
        if (lvl == 0)
        {
            return;
        }
        using (p(@class: "para<>"))
        {
            Go(lvl - 1);
        }
    }
}
