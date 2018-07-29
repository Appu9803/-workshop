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
    public partial class odi : Form
    {
        public odi()
        {
            InitializeComponent();
        }

        private void odi_Load(object sender, EventArgs e)
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
            try
            {
               
                string Buffer = string.Join("-", t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text);

                int i;
                try
                {
                    File.AppendAllText("odi.txt", Buffer);
                    for (i = 0; i <= (100 - Buffer.Length); i++)
                    {
                        File.AppendAllText("odi", "$");
                    }
                    File.AppendAllText("odi.txt", Environment.NewLine);
                    MessageBox.Show("records saved");
                    this.Hide();
                    Form4 f6 = new Form4();
                    f6.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            this.Hide();
            Form4 f = new Form4();
            f.Show();



        }

        private void t8_TextChanged(object sender, EventArgs e)
        {

        }

        private void t7_TextChanged(object sender, EventArgs e)
        {

        }

        private void t6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
