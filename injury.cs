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
    public partial class injury : Form
    {
        public injury()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

                string Buffer = string.Join("-", t1.Text, t2.Text, t3.Text, t4.Text, t5.Text);

                int i;
            try
            {
                File.AppendAllText("career.txt", Buffer);
               
                File.AppendAllText("career.txt", Environment.NewLine);
                MessageBox.Show("career records saved");
                this.Hide();
                Form2 f = new Form2();
                f.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }

        private void t4_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void injury_Load(object sender, EventArgs e)
        {
            t1.Text = Form2.player;
        }
    }
}
