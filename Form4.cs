using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            odi o = new odi();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            test t = new test();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            t20 t = new t20();
            t.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
