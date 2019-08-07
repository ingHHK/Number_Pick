using Number_Pick.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Number_Pick
{
    public partial class Form1 : Form
    {
        public int pick_num = 0;
        public int set_num = 0;
        public int add_count = 0;
        public int i = 0;
        public int liveList = 0;
        public int speed = 0;
        public int cheat_flag = 0;
        public List<int> listNumbers = new List<int>();
        public List<int> copylistNum = new List<int>();
        public Random ran = new Random();

        public void displayResult()
        {
            ListShow Display2 = new ListShow(ref copylistNum);
            Display2.ShowDialog();
        }

        public void randum_func()
        {
            int number;
            for (i = 0; i < pick_num; i++)
            {
                do
                {
                    number = ran.Next(1, set_num + 1);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
                copylistNum.Add(number);
            }

        }

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = this.button1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number_Setting_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_Picking_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.set_num = Convert.ToInt32(this.Number_Setting.Text);
            this.pick_num = Convert.ToInt32(this.Number_Picking.Text);
            if(cheat_flag == 0) copylistNum.Clear();
            pick_num -= add_count;
            if (set_num >= pick_num)
            {
                ShowResult.Clear();
                randum_func();
                foreach (int num in listNumbers)
                {
                    ShowResult.AppendText(Convert.ToString(num) + Environment.NewLine);
                    if (speed == 0) Thread.Sleep(300);
                    //pictureBox1.Image = Resources.jslot1;
                }
                listNumbers.Clear();
                add_count = 0;
                cheat_flag = 0;
            }
            else
            {
                ShowResult.Text = "";
                ShowResult.AppendText("Error..." + Environment.NewLine + "Setting 값이 Picking 값보다 커야 함");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = pick_num;
            ShowResult.Clear();
            listNumbers.Clear();
            copylistNum.Clear();
        }

        private void ShowResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Display = new Form2(ref listNumbers, ref copylistNum, ref add_count);
            Display.ShowDialog();
            add_count = Display.return_count();
            cheat_flag = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayResult();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) speed = 0;
            else if (checkBox1.Checked == true) speed = 1;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jslot2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jslot1;
        }
    }
}
