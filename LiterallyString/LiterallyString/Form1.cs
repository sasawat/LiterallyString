using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiterallyString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToText.Text = literallyTheString(FromText.Text);

        }

        private string literallyTheString(string input)
        {
            string retval = "";
            foreach(char x in input)
            {
                switch(x)
                {
                    case '\n':
                        retval += "\\n";
                        break;
                    case '\t':
                        retval += "\\t";
                        break;
                    case '\r':
                        retval += "\\r";
                        break;
                    case '\\':
                        retval += "\\\\";
                        break;
                    case '\v':
                        retval += "\\v";
                        break;
                    case '"':
                        retval += "\\\"";
                        break;
                    default:
                        retval += x;
                        break;
                }
            }
            return retval;
        }

        private void ToText_Click(object sender, EventArgs e)
        {
            ToText.SelectAll();
        }
    }
}
