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
    public partial class type : Form
    {
         public static string pid;
        public static string ap;
        public static char flag = 'n';
        public type()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void playerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void byPidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete a = new delete();
            a.Show();
        }

        private void byPidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            update u = new update();
            u.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("index.txt");

            {

                string app;
                while ((app = sr.ReadLine()) != null)

                {

                    string[] a = app.Split('-');
                    {
                        foreach (string word in a)
                        {
                            if (a[0] == t1.Text)
                            {
                                flag = 'y';

                                break;
                            }

                            else
                            {
                                flag = 'n';

                            }
                        }
                    }
                }



                if (flag == 'y')
                {
                    ap = t1.Text;
                    this.Hide();
                    update f = new update();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("invalid player", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete d = new delete();
            d.Show();
        }

        private void type_Load(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
