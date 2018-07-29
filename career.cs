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
    public partial class career : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\cricket.mdf;Integrated Security=True;Connect Timeout=30");

        public career()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
                
            
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void career_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("career.txt");

            {

                string app;
                while ((app = sr.ReadLine()) != null)

                {

                    string[] a = app.Split('-');
                    {
                        foreach (string word in a)
                        {
                            if (a[0] == Form3.ap)
                            {
                                t1.Text = a[0];
                                t2.Text = a[1];
                                t3.Text = a[2];
                                t4.Text = a[3];
                                t5.Text = a[4];
                               

                            }

                        }
                    }
                }

            }
            sr.Close();
            {
                StreamReader s = new StreamReader("injury.txt");

                {

                    string app;
                    while ((app = s.ReadLine()) != null)

                    {

                        string[] a = app.Split('-');
                        {
                            foreach (string word in a)
                            {
                                if (word == Form1.ap)
                                {
                                    t21.Text = a[0];
                                    t22.Text = a[1];
                                    t23.Text = a[2];
                                   

                                }

                            }
                        }
                    }

                }
                s.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Developed by:Apoorva.g and Rakshith H.R", "about us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 t = new Form1();
            t.Show();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Developed by:Apoorva.G and Rakshith H.R", "about us", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
