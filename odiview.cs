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
    public partial class odiview : Form
    {
        public odiview()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void odiview_Load(object sender, EventArgs e)
        {
            t1.Text = Form3.pid;
            {
                StreamReader sr = new StreamReader("odi.txt");

                {

                    string app;
                    while ((app = sr.ReadLine()) != null)

                    {

                        string[] a = app.Split('-');
                        {
                            foreach (string word in a)
                            {
                                if (word == Form3.pid)
                                {
                                    t2.Text = a[1];
                                    t3.Text = a[2];
                                    t4.Text = a[3];
                                    t5.Text = a[4];
                                    t6.Text = a[5];
                                    t7.Text = a[6];
                                    t8.Text = a[7];

                                }

                            }
                        }
                    }
                }
                sr.Close();
            }
            {
                StreamReader sr = new StreamReader("t20.txt");

                {

                    string app;
                    while ((app = sr.ReadLine()) != null)

                    {

                        string[] a = app.Split('-');
                        {
                            foreach (string word in a)
                            {
                                if (word == Form3.pid)
                                {
                                    t22.Text = a[1];
                                    t23.Text = a[2];
                                    t24.Text = a[3];
                                    t25.Text = a[4];
                                    t26.Text = a[5];
                                    t27.Text = a[6];
                                    t28.Text = a[7];

                                }

                            }
                        }
                    }
                }
                sr.Close();
            }
            {
                StreamReader sr = new StreamReader("test.txt");

                {

                    string app;
                    while ((app = sr.ReadLine()) != null)

                    {

                        string[] a = app.Split('-');
                        {
                            foreach (string word in a)
                            {
                                if (word == Form3.pid)
                                {
                                    t32.Text = a[1];
                                    t33.Text = a[2];
                                    t34.Text = a[3];
                                    t35.Text = a[4];
                                    t36.Text = a[5];
                                    t37.Text = a[6];
                                    t38.Text = a[7];

                                }

                            }
                        }
                    }
                }
                sr.Close();
            }
        
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
