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
    public partial class Form2 : Form
    {
        public static int pos;
        public static string ap;
        public static string player;
        public static string pi;
        public static char flag = 'n';
        SqlCommand cmd;
        string imgloc = "";
        public Form2()
        {
            InitializeComponent();
        }
        FileStream fs, fs1;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            type F = new type();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            {
                StreamReader s = new StreamReader("index.txt");

                {

                    string app;
                    while ((app = s.ReadLine()) != null)

                    {

                        string[] a = app.Split('-');
                        {
                            foreach (string word in a)
                            {
                                if (a[0] == pid.Text)
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
                    s.Close();



                    if (flag == 'y')
                    {
                        MessageBox.Show("primary key violation...!PID exists....", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        Form2 f = new Form2();
                        f.Show();

                    }
                    else
                    {
                        player = pid.Text;
                        fs = new FileStream("player.txt", FileMode.Append);
                        fs1 = new FileStream("index.txt", FileMode.Append);
                        int year = Int32.Parse(textBox3.Text);
                        int age = (2018 - year);
                        StreamWriter sr = new StreamWriter(fs);
                        StreamWriter sw = new StreamWriter(fs1);
                        string Buffer = string.Join("-", pid.Text, fname.Text, lname.Text, country.Text, (textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text), age, height.Text, bat.Text, bowl.Text, "-",Environment.NewLine);

                        
                        

                       

                        try
                        {
                            sr.WriteLine(Buffer);
                            var pos = fs.Position;
                            int a = (int)pos;
                            string ind = string.Join("-", pid.Text, a);
                            sw.WriteLine(ind);

                            sr.Close();
                            sw.Close();
                            fs.Close();
                            fs1.Close();
                            

                          
                            MessageBox.Show("records saved");
                            this.Hide();
                            Form4 f = new Form4();
                            f.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
          pi = pid.Text;
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            injury i = new injury();
            i.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            injuryenter i = new injuryenter();
            i.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Orange;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Aqua;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Orange;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Aqua;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Orange;
        }

     
    }
} 