using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Task8Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            string pattern = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";

            MatchCollection matches;
            Regex reg = new Regex(pattern);
            matches = reg.Matches(text);

            {
                for (int i = 0; i < matches.Count; i++)
                {
                    string updDate = DateTime.Parse(matches[i].Value).AddDays(+1).ToShortDateString();
                    text = text.Replace(matches[i].Value, updDate);
                }
                textBox2.Text += text;
            }
        }
    }
}
