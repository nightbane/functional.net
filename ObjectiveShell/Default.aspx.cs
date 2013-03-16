using System;
using System.Linq;
using System.Web.UI;
using ObjectiveShell.UnitTests;

namespace ObjectiveShell
{
    public partial class Default : Page
    {
        private readonly FSharpListHelper listhelper = new FSharpListHelper();

        protected void Page_Load(object sender, EventArgs e)
        {
            var sharplist = FizzBuzzer.TranslateList(FizzBuzzer.HundredList);
            var list = listhelper.ConvertList(sharplist);
            litOutput.Text = list.Aggregate(string.Empty, (current, item) => current + (item + "<br />\n"));
        }
    }
}