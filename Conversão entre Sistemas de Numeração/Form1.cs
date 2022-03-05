using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversão_entre_Sistemas_de_Numeração
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string convHex(int r)
        {
            string v = "";
            if (r == 10)
                v = "A";
            else if (r == 11)
                v = "B";
            else if (r == 12)
                v = "C";
            else if (r == 13)
                v = "D";
            else if (r == 14)
                v = "E";
            else if (r == 15)
                v = "F";
            else
                v = r.ToString();
            return v;
        }

        private int conValor(string s)
        {
            int j = 0;
            switch (s)
            {
                case "A":
                    j = 10;
                    break;
                case "B":
                    j = 11;
                    break;
                case "C":
                    j = 12;
                    break;
                case "D":
                    j = 13;
                    break;
                case "E":
                    j = 14;
                    break;
                case "F":
                    j = 15;
                    break;
                default:
                    j = int.Parse(s);

                    break;

            }
            return j;
        }

        private void buttonCDBinário_Click_1(object sender, EventArgs e)
        {
            string s = "";
            if (textBoxNDecimal.Text != "")
            {
                int n = int.Parse(textBoxNDecimal.Text);
                while (n != 1)
                {
                    s = (n % 2).ToString() + s;

                    n = n / 2;


                }
                s = "1" + s;
                textboxResultado.Text = s;
            }
        }

        private void buttonCBDecimal_Click_1(object sender, EventArgs e)
        {
            double res = 0;
            string s = textBoxNBinário.Text;
            if (s != "")
            {
                int t = s.Length;
                for (int i = 0; i < t; i++)
                {
                    int ex = t - i - 1;
                    res = (int.Parse(s[i].ToString()) * Math.Pow(2, ex)) + res;
                }
            }
            textboxResultado.Text = res.ToString();
        }

        private void buttonCDOctal_Click_1(object sender, EventArgs e)
        {
            string s = "";
            if (textBoxNODecimal.Text != "")
            {
                int n = int.Parse(textBoxNODecimal.Text);
                while ((n != 1) && (n != 0))
                {
                    s = (n % 8).ToString() + s;

                    n = n / 8;

                }
                if (n != 0)
                    s = n.ToString() + s;
                textboxResultado.Text = s;
            }
        }

        private void buttonCODecimal_Click_1(object sender, EventArgs e)
        {
            double res = 0;
            string s = textBoxNOctal.Text;
            if (s != "")
            {
                int t = s.Length;
                for (int i = 0; i < t; i++)
                {
                    int ex = t - i - 1;
                    res = (int.Parse(s[i].ToString()) * Math.Pow(8, ex)) + res;
                }
            }
            textboxResultado.Text = res.ToString();
        }

        private void buttonCDHexadecimal_Click_1(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                if (textBoxNHDecimal.Text != "")
                {
                    int n = int.Parse(textBoxNHDecimal.Text);
                    while (n != 0)
                    {
                        int resto = n % 16;
                        string st = convHex(resto);
                        s = st + s;
                        n = n / 16;

                    }
                    if (n != 0)
                        s = n.ToString() + s;
                }
                textboxResultado.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

        private void buttonCHDecimal_Click(object sender, EventArgs e)
        {
            double res = 0;
            string s = textBoxNHexadecimal.Text;
            int t = s.Length;
            for (int i = 0; i < t; i++)
            {
                int ex = t - i - 1;
                int val = conValor(s[i].ToString());
                res = (val * Math.Pow(16, ex)) + res;
            }
            textboxResultado.Text = res.ToString();
        }
    }
}





