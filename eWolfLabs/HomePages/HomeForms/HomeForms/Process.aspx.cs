using HomeForms.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Process : System.Web.UI.Page
{
    private LiteralControl parsedErrorMedssage = new LiteralControl($"Show data here ");

    protected void Page_Load(object sender, EventArgs e)
    {
        pnlUserdata.Controls.Add(parsedErrorMedssage);
    }

    protected void ProcessError_Click(object sender, EventArgs e)
    {
    }

    protected void ButtonTestBatFile_Click(object sender, EventArgs e)
    {
        int exitCode = BatchFileHelper.RunUnitTestFor(@"C:\Git\Plato\tests\BritishGasTests\bin\Debug\BritishGasTests.dll");

        if (exitCode == 0)
        {
            ButtonTestBatFile.BackColor = Color.Green;
        }
        else
        {
            ButtonTestBatFile.BackColor = Color.Red;
        }
    }

    protected void ButtonTestBatFile2_Click(object sender, EventArgs e)
    {
        int exitCode = BatchFileHelper.RunUnitTestFor(@"C:\Git\Plato\tests\BritishTelecom\bin\Debug\BTUnitTests.dll");

        if (exitCode == 0)
        {
            ButtonTestBatFile2.BackColor = Color.Green;
        }
        else
        {
            ButtonTestBatFile2.BackColor = Color.Red;
        }
    }

    protected void TextBoxLog_TextChanged(object sender, EventArgs e)
    {
        // we have update the text
        string exception = TextBoxLog.Text;
        ExceptionDetails ed = new ExceptionDetails(exception);
        parsedErrorMedssage.Text = ed.GetDisplayMessage();
    }

    protected void BuildPlato_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Here");
    }
}
