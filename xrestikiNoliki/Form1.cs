using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xrestikiNoliki
{
    public partial class Form1 : Form
    {
        string t = "";
        Random rnd = new Random();
        int[] array = new int[9];
        Button[] btn = new Button[9];
        public Form1()
        {
            InitializeComponent();
            if (rnd.Next(1, 10) <= 5)
            {
                t = "Крестики";
                label1.Text = "Ходят X";
            }
            else
            {
                t = "1";
                label1.Text = "Ходят 0";
            }
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (t == "Крестики")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "Ходят 0";
                        t = "1";
                        btn[i].Enabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }
            else //нолики
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "O";
                        label1.Text = "Ходят X";
                        t = "Крестики";
                        btn[i].Enabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }
            chekWin();
        }
        void chekWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show("Победили" + button1.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show("Победили" + button4.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button8.Text != "")
                {
                    MessageBox.Show("Победили" + button8.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show("Победили" + button1.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    MessageBox.Show("Победили" + button2.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show("Победили" + button3.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show("Победили" + button1.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button5.Text != "")
                {
                    MessageBox.Show("Победили" + button3.Text);
                    for (int i = 0; i < btn.Length; i++)
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            bool isDraw = true;
            for (int i = 0; i < btn.Length; i++)
            {
                if (btn[i].Text == "")
                {
                    isDraw = false;
                    break;
                }
                if (!isDraw) break;

            }
            if (isDraw)
            {
                MessageBox.Show("Ничья!");
            }

        }

    }
    

}
