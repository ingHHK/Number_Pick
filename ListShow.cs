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
    public partial class ListShow : Form
    {
        public ListShow(ref List<int> listNumbers)
        {
            InitializeComponent();
            textBox1.Clear();
            foreach (int num in listNumbers)
                textBox1.AppendText(Convert.ToString(num) + Environment.NewLine);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
