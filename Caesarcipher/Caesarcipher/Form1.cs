using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesarcipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 447;
            this.Width = 492;
            shift.Text = "2";
        }
        
        void Ecode()
        {
            char[] E = Old.Text.ToCharArray();
            int No = int.Parse(shift.Text);
            for (int i = 0; i < E.Length; i++)
            {
                char word = E[i];
                
                if (word >= 'A' && word <= 'Z')
                {
                    word = (char)(word + No);
                    if (word > 'Z')
                    {
                        word = (char)(word - 26);
                    }
                    else if (word < 'A')
                    {
                        word = (char)(word + 26);
                    }
                    E[i] = word;
                }
                else if (word >= 'a' && word <= 'z')
                {
                    word = (char)(word + No);
                    if (word > 'z')
                    {
                        word = (char)(word - 26);
                    }
                    else if (word < 'a')
                    {
                        word = (char)(word + 26);
                    }
                    E[i] = word;
                }
                else
                {
                    E[i] = word;
                }
            }
            New.Text = new string(E);
            label1.Text = "原文";
            label2.Text = "密文";
            label3.Text = "偏移";
            label1.Text += Old.Text;
            label2.Text += new string(E);
            label3.Text += shift.Text;
        }
        
        void Dcode()
        {
            char[] de = New.Text.ToCharArray();
            int No = int.Parse(shift.Text);
            for (int i=0; i<de.Length;i++)
            {
                char word = de[i];
                if (word >= 'A' && word <= 'Z')
                {
                    word = (char)(word - No);
                    if (word > 'Z')
                    {
                        word = (char)(word - 26);
                    }
                    else if (word < 'A')
                    {
                        word = (char)(word + 26);
                    }
                    de[i] = word;
                }
                else if (word >= 'a' && word <=  'z')
                {
                    word = (char)(word - No);
                    if (word > 'z')
                    {
                        word = (char)(word - 26);
                    }
                    else if (word < 'a')
                    {
                        word = (char)(word + 26);
                    }
                    de[i] = word;
                }
                else
                {
                    de[i] = word;
                }
                
            }
            Old.Text = new string(de);
            label1.Text = "原文";
            label2.Text = "密文";
            label3.Text = "偏移";
            label1.Text += new string(de);
            label2.Text += New.Text;
            label3.Text += shift.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old.Text = "";
            New.Text = "";
            shift.Text = "2";
            label1.Text = "原文";
            label2.Text = "密文";
            label3.Text = "偏移";
            encode.Checked = false;
            decode.Checked = false;
        }

        private void encode_CheckedChanged(object sender, EventArgs e)
        {
            if (encode.Checked && Old.Text != "")
            {
                Ecode();
            }
        }

        private void decode_CheckedChanged(object sender, EventArgs e)
        {
            if (decode.Checked && New.Text != "")
            {
                Dcode();
            }
        }



        private void New_TextChanged(object sender, EventArgs e)
        {
            if (decode.Checked && New.Text != "")
            {
                Dcode();
            }
        }

        private void Old_TextChanged_1(object sender, EventArgs e)
        {
            if (encode.Checked && Old.Text != "")
            {
                Ecode();
            }
        }

        
    }
}
