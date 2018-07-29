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
    public partial class odiupdate : Form
    {
        public odiupdate()
        {
            InitializeComponent();
        }
        public static string old, lat;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void odiupdate_Load(object sender, EventArgs e)
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
                            if (a[0] == type.ap)
                            {
                                t1.Text = a[0];
                                t2.Text = a[1];
                                t3.Text = a[2];
                                t4.Text = a[3];
                                t5.Text = a[4];
                                t6.Text = a[5];
                                t7.Text = a[6];
                                t8.Text = a[7];

                                old = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text + "-" + t6.Text + "-" + t7.Text + "-" + t8.Text;

                            }

                        }
                    }
                }

            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lat = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text + "-" + t6.Text + "-" + t7.Text + "-" + t8.Text;
            try
            {


                string str = File.ReadAllText("odi.txt");
                str = str.Replace(old, lat);
                File.WriteAllText("odi.txt", str);
                MessageBox.Show("records updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            update odi = new update();
            odi.Show();
        }
    }
}
