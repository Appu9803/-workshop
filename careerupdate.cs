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
    public partial class careerupdate : Form
    {
        public careerupdate()
        {
            InitializeComponent();
        }
        public static string old, lat;
        private void careerupdate_Load(object sender, EventArgs e)
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
                            if (a[0] == type.ap)
                            {
                                t1.Text = a[0];
                                t2.Text = a[1];
                                t3.Text = a[2];
                                t4.Text = a[3];
                                t5.Text = a[4];

                                old = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text;

                            }

                        }
                    }
                }

            }
            sr.Close();
        }

        private void t5_TextChanged(object sender, EventArgs e)
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

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            update u = new update();
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lat = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text;
            try
            {


                string str = File.ReadAllText("career.txt");
                str = str.Replace(old, lat);
                File.WriteAllText("career.txt", str);
                MessageBox.Show("records updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
