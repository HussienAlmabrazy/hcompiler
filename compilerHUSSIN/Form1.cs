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
        static public int indix = 0;
        static List<Token> Tokens;

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

                lexi.Text = (codeText);
                var tokens = LaxicalLayer.stringToToken(codeText);
                #region
                foreach (var token in tokens)
                {

                    if (token.isStructureName)
                    {
                        tok.Items.Add((token._text + "  structure name"));
                    }
                    else if (token.isDataType)
                    {
                        tok.Items.Add((token._text + "  data type"));

                    }
                    else if (token.isCondition)
                    {
                        tok.Items.Add((token._text + "  Condition"));

                    }
                    else if (token.isclass)
                    {
                        tok.Items.Add((token._text + "  Class"));

                    }
                    else if (token.isfunction)
                    {
                        tok.Items.Add((token._text + "  Function"));

                    }
                    else if (token.isVar)
                    {
                        tok.Items.Add((token._text + "  var"));
                    }
                    else if (token.isReservedW)
                    {
                        tok.Items.Add((token._text + "  Reserved word"));
                    }
                    else if (token.isNumber)
                    {
                        tok.Items.Add((token._text + "  number"));
                    }
                    else if (token.operators)
                    {
                        tok.Items.Add((token._text + "  Operator"));
                    }
                    else if (token.isSymobl)
                    {
                        tok.Items.Add((token._text + "  Symbol"));
                    }

                    else
                    {
                        tok.Items.Add((token._text + "  non"));
                    }

                }
                #endregion
                
                program.start(tokens, indix);
            }
            else
                MessageBox.Show("write your code...");
            //           #region
        }
     

        class program
        {
            static public void start(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.start_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                else if (newtranslat.start_s3_or_s2_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                else if (newtranslat.start_s1)
                {
                    indix++;
                    S1(tokens2,indix);
                }
                else if (newtranslat.start_s0)
                {
                    indix++;
                    S0(tokens2, indix);
                }
                else
                   MessageBox.Show("error");
            }

            static private void S0(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s0_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                else
                    MessageBox.Show("error");
            }

            static private void S1(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s1_s5)
                {
                    indix++;
                    S5(tokens2,indix);
                }else 
                MessageBox.Show("erroe");
            }

            private static void S5(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s5_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                if (newtranslat.s5_s40)
                {
                    indix++;
                    S40(tokens2, indix);
                }
                else MessageBox.Show("error");
            }

            static private void S31(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s30_s301_or_s31_s301)
                {
                    indix++;
                    S301(tokens2, indix);
                }
                //else if (newtranslat.)
                //{

                //}
                else MessageBox.Show("erorr");
            }

            static private void S301(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s301_f)
                {
                    indix++;
                    F(tokens2, indix);
                }
                else if (newtranslat.s301_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                else if (newtranslat.s301_s31)
                {
                    indix++;
                    S31(tokens2, indix);
                }
                else if (newtranslat.s301_s5)
                {
                    indix++;
                    S5(tokens2, indix);
                }
                else MessageBox.Show("reror");
            }

            static private void S3(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s3_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                else if (newtranslat.s3_s31_or_s30_s31)
                {
                    indix++;
                    S31(tokens2, indix);
                }
                else if (newtranslat.s3_s30)
                {
                    indix++;
                    S30(tokens2, indix);
                }
                else if (newtranslat.s3_f)
                {
                    indix++;
                    F(tokens2, indix);
                }
                else if (newtranslat.s3_s40)
                {
                    indix++;
                    S40(tokens2, indix);
                }
                else if (newtranslat.s3_s5)
                {
                    indix++;
                    S5(tokens2, indix);
                }
                else
                    MessageBox.Show("error");
            }

            static private void S40(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s40_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                else if (newtranslat.s40_f)
                {
                    indix++;
                    F(tokens2, indix);
                }
                else if (newtranslat.s40_s6_f_s6)
                {
                    indix++;
                    S6(tokens2, indix);
                }
                else if (newtranslat.S40toS40)
                {
                    indix++;
                    S40(tokens2, indix);
                }
                else
                MessageBox.Show("error");
            }

            static private void F(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.f_s40)
                {
                    indix++;
                    S40(tokens2, indix);
                }
                else if (newtranslat.f_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                else if (newtranslat.f_s1)
                {
                    indix++;
                    S1(tokens2, indix);
                }
                else if (newtranslat.s40_s6_f_s6)
                {
                    indix++;
                    S6(tokens2, indix);
                }
                else if (newtranslat.f_s9)
                {
                    indix++;
                    S9(tokens2, indix);
                }
                else if (newtranslat.f_s11)
                {
                    indix++;
                    S11(tokens2, indix);
                }
                else if (newtranslat.f_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                else Console.WriteLine("error");
                Console.WriteLine("you are in the end FFF");
            }

            private static void S11(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s11_s7)
                {
                    indix++;
                    S7(tokens2, indix);
                }
                else MessageBox.Show("errror");
            }

            private static void S7(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s7_s2)
                {
                    indix++;
                    S2(tokens2, indix);
                }
                if (newtranslat.s7_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                else MessageBox.Show("errror");
            }

            private static void S9(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s9_f)
                {
                    indix++;
                    F(tokens2,indix);
                }
                else MessageBox.Show("errror");
            }

            private static void S6(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s6_s10)
                {
                    indix++;
                    S10(tokens2,indix);
                }
                else MessageBox.Show("errror");
            }

            private static void S10(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s10_s7_or_s11_s7)
                {
                    indix++;
                    S7(tokens2, indix);
                }
                else MessageBox.Show("errror");
            }

            static private void S30(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.s30_s301_or_s31_s301)
                {
                    indix++;
                    S301(tokens2, indix);
                }
                else MessageBox.Show("erorr");
            }

            static private void S2(List<Token> tokens2, int indix)
            {
                Translator newtranslat = new Translator(tokens2[indix]);
                if (newtranslat.start_s3_or_s2_s3)
                {
                    indix++;
                    S3(tokens2, indix);
                }
                else
                   MessageBox.Show("error");
                //}
            }
        }
        private void tok_TextChanged(object sender, EventArgs e)
        {

        }

        private void tok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

   

}
