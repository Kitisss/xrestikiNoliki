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
    }
    

}
