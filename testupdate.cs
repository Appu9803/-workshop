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
    public partial class testupdate : Form
    {
        public testupdate()
        {
            InitializeComponent();
        }
        public static string old, lat;
        private void testupdate_Load(object sender, EventArgs e)
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
                            if (a[0] == update.pid)
                            {
                                t21.Text = a[0];
                                t22.Text = a[1];
                                t23.Text = a[2];
                                t24.Text = a[3];
                                t25.Text = a[4];
                                t26.Text = a[5];
                                t27.Text = a[6];
                                t28.Text = a[7];
                                old = t21.Text + "-" + t22.Text + "-" + t23.Text + "-" + t24.Text + "-" + t25.Text + "-" + t26.Text + "-" + t27.Text + "-" + t28.Text;

                            }

                        }
                    }
                }
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lat = t21.Text + "-" + t22.Text + "-" + t23.Text + "-" + t24.Text + "-" + t25.Text + "-" + t26.Text + "-" + t27.Text + "-" + t28.Text;
            try
            {


                string str = File.ReadAllText("test.txt");
                str = str.Replace(old, lat);
                File.WriteAllText("test.txt", str);
                MessageBox.Show("records updated");
                this.Hide();
                update u = new update();
                u.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            update u = new update();
            u.Show();
        }
    }
}
