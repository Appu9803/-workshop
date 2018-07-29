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
    public partial class t20 : Form
    {
        public t20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Buffer = string.Join("-", t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text);

                int i;
                try
                {
                    File.AppendAllText("t20.txt", Buffer);
                    for (i = 0; i <= (100 - Buffer.Length); i++)
                    {
                        File.AppendAllText("t20", "$");
                    }
                    File.AppendAllText("t20.txt", Environment.NewLine);
                    MessageBox.Show("records saved");
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            t1.Text = Form2.player;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
