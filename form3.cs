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
using System.Drawing.Imaging;


namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       public static string pid,ap;
        public static char flag = 'n';

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

      
        private void Form3_Load(object sender, EventArgs e)
        {


           
            int i = 0;
            StreamReader sr = new StreamReader("player.txt");
           
            {

                string app;
               while((app = sr.ReadLine())!=null)
                
                {
                    
                string[] a = app.Split('-');
                {
                        foreach (string word in a)
                        {
                            if (word ==Form1.ap)
                            {
                                textBox1.Text = a[0];
                                textBox2.Text = a[1] +" "+ a[2];
                                textBox4.Text = a[3];
                                textBox5.Text = a[4];
                                textBox6.Text = a[5];
                                textBox7.Text = a[6];
                                textBox8.Text = a[7];
                                textBox9.Text = a[8];
                            
                            }

                        }
                    }
                }
               
            }
            sr.Close();
            {
              
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pid = textBox1.Text;
            {
                char flag = 'n';
                string a;
                StreamReader sr = new StreamReader("odi.txt");
                while ((a = sr.ReadLine()) != null)
                {
                    if (a.StartsWith(textBox1.Text))
                    {
                        flag = 'y';
                        break;
                    }
                    else
                    {
                        flag = 'n';

                    }

                }
                if (flag == 'y')
                {
                  
                    this.Hide();
                    odiview f1 = new odiview();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("odi statistics not available", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sr.Close();

            }
            


        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
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
                            if (a[0] == textBox1.Text)
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
                    ap = textBox1.Text;
                    this.Hide();
                    career f = new career();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("career data not exists...!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }




        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Developed by:Naveen.A kiran.M and jeevan", "about us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Yellow;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightSeaGreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
