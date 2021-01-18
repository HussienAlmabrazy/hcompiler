using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace compilerHUSSIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void scan_Click(object sender, EventArgs e)
        {
            if (txtb.TextLength > 0)
            {
                string codeText = txtb.Text;

                codeText = LaxicalLayer.formatting(codeText);

               lexi.Text=( codeText);
                var tokens = LaxicalLayer.stringToToken(codeText);
                foreach (var token in tokens)
                {
                    if (token.isStructureName)
                   { 
                        tok.Text=(token._text + "  structure name\n");
                    }
                    else if (token.isDataType)
                    {
                        tok.Text = (token._text + "  data type\n");

                    }
                    else if (token.isVar)
                    {
                        tok.Text = (token._text + "  var\n");
                    }
                    else if (token.isNumber)
                    {
                        tok.Text = (token._text + "  number\n");
                    }
                    else if (token.operators)
                    {
                        tok.Text = (token._text + "  Operator\n");
                    }
                    else if (token.isSymobl)
                    {
                        tok.Text = (token._text + "  Symbol\n");
                    }

                    else
                    {
                        tok.Text = (token._text + "  non");
                    }
                }
            }
            else
                MessageBox.Show("write your code...");
            //           #region
        }

        
        private void tok_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
