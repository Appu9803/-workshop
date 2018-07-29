using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            t1.Text = Form2.player;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
                string Buffer = string.Join("-", t1.Text,t2.Text,t3.Text,t4.Text,t5.Text,t6.Text,t7.Text,t8.Text);
               
                int i;
                try
                {
                    File.AppendAllText("test.txt", Buffer);
                    for (i = 0; i <= (100 - Buffer.Length); i++)
                    {
                        File.AppendAllText("test", "$");
                    }
                    File.AppendAllText("test.txt", Environment.NewLine);
                    MessageBox.Show("records saved");
                this.Hide();
                Form4 f = new Form4();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
