using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twobugs1bird
{
    public partial class Form1 : Form
    {
        int bg1;
        int bg2;
        int b;
        int bug1all;
        int bug2all;
        int bridall;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //欄位不得為空值
            if (string.IsNullOrEmpty(bug1.Text))
            {
                MessageBox.Show("糖果數量欄位請勿留白");
                return;
            }

            if (string.IsNullOrEmpty(bug2.Text))
            {
                MessageBox.Show("糖果數量欄位請勿留白");
                return;
            }

            if (string.IsNullOrEmpty(bird.Text))
            {
                MessageBox.Show("糖果數量欄位請勿留白");
                return;
            }

            bg1 = int.Parse(bug1.Text);
            bg2 = int.Parse(bug2.Text);
            b = int.Parse(bird.Text);
            bug1all = bg1 / 12;
            bug2all = bg2 / 12;
            bridall = b / 12;

            if (bg1 >= 144 && bg1 % 12 == 0)
            {
                bug1all = (bg1 / 12) + (bg1 / 144);
            }
            else
            {
                bug1all = bg1 / 12;
            }

            if (bg2 >= 14 && bg2 % 12 == 0)
            {
                bug2all = (bg2 / 12) + (bg2 / 144);
            }
            else
            {
                bug2all = bg2 / 12;
            }

            if (b >= 144 && b % 12 == 0)
            {
                bridall = (b / 12) + (b / 144);
            }
            else
            {
                bridall = b / 12;
            }

            textBox4.Text = bug1all.ToString();
            textBox5.Text = bug2all.ToString();
            textBox6.Text = bridall.ToString();
            textBox1.Text = (bug1all + bug2all + bridall).ToString();
            textBox2.Text = ((bug1all + bug2all + bridall) * 500).ToString();
            textBox3.Text = ((bug1all + bug2all + bridall) * 1000).ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bug1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允許輸入整數的判定
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
               e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
               e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
               e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
               e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
