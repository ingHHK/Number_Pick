using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Pick
{
    public partial class Form2 : Form
    {
        public List<int> listNum;
        public List<int> copylist;
        public int add_count;
        public int add_num;
        

        public Form2(ref List<int> listNum, ref List<int> copylist, ref int add_count)
        {
            InitializeComponent();
            this.listNum = listNum;
            this.copylist = copylist;
            this.add_count = add_count;
            this.AcceptButton = this.button1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.add_num = Convert.ToInt32(this.textBox1.Text);
            listNum.Add(add_num);
            copylist.Add(add_num);
            textBox2.AppendText(add_num + Environment.NewLine);
            add_count++;            
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public int return_count()
        {         
            return add_count;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
