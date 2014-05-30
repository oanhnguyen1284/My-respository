using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SSRep
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ReplacingString(string s)
        {
           
            const string pattern = @"<\b(\w+),\s(\w+)\(\d+\),>";//replace for <RATE_TYPE, nvarchar(4),>
            const string pattern1 = @"<\b(\w+),\s(\w+)\(\d+[,]\d+\),>";//replace for <SUBTOTAL_2, decimal(17,2),>
            const string pattern2 = @"<\b(\w+),\s(\w+),>";// replace for <AUDIT_CREATED_DTM, datetime,>
            const string pattern3 = @"<\/\b(\w+)\/(\w+),\s(\w+)\(\d+\),>"; //replace for </BIC/PSDBILLPL, nvarchar(10),>
            const string pattern4 = @"<\/\b(\w+)\/(\w+),\s(\w+)\(\d+[,]\d+\),>"; // replace for </BIC/PSDBILVAL, decimal(17,2),>
           
            string dest = Regex.Replace(s, pattern, "?");
            dest = Regex.Replace(dest, pattern1, "?");
            dest = Regex.Replace(dest, pattern2, "?");
            dest = Regex.Replace(dest, pattern3, "?");
            dest = Regex.Replace(dest, pattern4, "?");
            return dest;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string s= ReplacingString(rtbLeft.Text);
            rtbRight.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbLeft.Text = string.Empty;
            rtbRight.Text = string.Empty;
        }
     
     
    }
}
