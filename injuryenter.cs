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
    public partial class injuryenter : Form
    {
        public injuryenter()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Buffer = string.Join("-", t21.Text, t22.Text, t23.Text,"-");

                int i;
                try
                {
                    File.AppendAllText("injury.txt", Buffer);
                  
                    File.AppendAllText("injury.txt", Environment.NewLine);
                    MessageBox.Show("injury records saved");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();

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
            
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void injuryenter_Load(object sender, EventArgs e)
        {
            t21.Text = Form2.player;
        }
    }
}
