using System;
using System.Linq;
using System.Web.UI;

namespace ObjectiveShell
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fsharplist = FizzBuzzer.TranslateList(FizzBuzzer.HundredList);
            litOutput.Text = fsharplist.Aggregate(string.Empty, (current, item) => current + (item + "<br />\n"));
        }
    }
}