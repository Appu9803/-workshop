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
using System.Drawing.Imaging;
using System.IO;
namespace WindowsFormsApp5
{
    
    public partial class Form1 : Form
    {
        public static int count;
        public static string fname,lname,country,ap;
        public static char flag = 'n';
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("index.txt");
            int c=0;
            while(sr.ReadLine()!=null)
            {
                c++;
            }
            count = c;
            sr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "apoorva" && textBox2.Text == "appu")
            {

                this.Hide();
                type f = new type();
                f.Show();
            }
            else
            {
                MessageBox.Show("invalid username");
            }
        }

        private void label11_Click(object sender, EventArgs e)
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
                            if (a[0] == textBox3.Text)
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
                    ap = textBox3.Text;
                    this.Hide();
                    Form3 f = new Form3();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("invalid player", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel5.BackColor = Color.SkyBlue;

        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel6.BackColor = Color.SkyBlue;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                panel3.BackColor = Color.White;
                panel5.BackColor = Color.SkyBlue;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "User Name";
                textBox1.ForeColor = Color.Silver;
                panel3.BackColor = Color.Transparent;
                panel5.BackColor = Color.Transparent;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text=="Pass Word")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
                panel4.BackColor = Color.White;
                panel6.BackColor = Color.SkyBlue;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                textBox2.Text = "Pass Word";
               
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar ='\0';
            
           
                panel4.BackColor = Color.Transparent;
                panel6.BackColor = Color.Transparent;
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label3.Focus();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("index.txt");
            string a;
            a = sr.ReadToEnd();
            {
                richTextBox2.Text = a;

            }
            sr.Close();
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            if (textBox3.Text == "PID")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                

            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "PID";
                textBox3.ForeColor = Color.Silver;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                            if (a[0] == textBox3.Text)
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
                    ap = textBox3.Text;
                    this.Hide();
                    Form3 f = new Form3();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("invalid player", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }


    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }
    }
}
