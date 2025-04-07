using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace AppRegex;

public partial class Form1 : Form
{
    string patternEmail = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSendEmail_Click(object sender, EventArgs e)
    {        
        MessageBox.Show(Regex.IsMatch(textBoxEmail.Text, patternEmail) ? "Valid" : "Invalid");
    }
}
