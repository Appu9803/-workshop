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
    public partial class update : Form
    {
        public static string old, lat;
        public static string pid;
        string imgloc = "";
        private Panel panel2;
        private Button button6;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private ComboBox t4;
        private Button button1;
        private TextBox t9;
        private TextBox t8;
        private TextBox t7;
        private TextBox t3;
        private TextBox t2;
        private TextBox t1;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem odiToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem t20ToolStripMenuItem;
        private TextBox t6;
        private Label label9;
        private TextBox t5;
        private Label label2;

        public update()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t9 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.t6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(11, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 617);
            this.panel2.TabIndex = 53;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(4, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 60);
            this.button6.TabIndex = 29;
            this.button6.Text = "Injury details";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 61);
            this.button4.TabIndex = 27;
            this.button4.Text = "career details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 281);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(133, 69);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odiToolStripMenuItem,
            this.testToolStripMenuItem,
            this.t20ToolStripMenuItem});
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(105, 65);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // odiToolStripMenuItem
            // 
            this.odiToolStripMenuItem.Name = "odiToolStripMenuItem";
            this.odiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odiToolStripMenuItem.Text = "odi";
            this.odiToolStripMenuItem.Click += new System.EventHandler(this.odiToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // t20ToolStripMenuItem
            // 
            this.t20ToolStripMenuItem.Name = "t20ToolStripMenuItem";
            this.t20ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.t20ToolStripMenuItem.Text = "t20";
            this.t20ToolStripMenuItem.Click += new System.EventHandler(this.t20ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 107);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update player Details";
            // 
            // t4
            // 
            this.t4.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.FormattingEnabled = true;
            this.t4.Items.AddRange(new object[] {
            "INDIA",
            "AUSTRALIA",
            "SRILANKA",
            "NEW ZEALAND",
            "SOUTH AFRICA",
            "WEST INDIES",
            "BANGLADESH"});
            this.t4.Location = new System.Drawing.Point(321, 339);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(254, 40);
            this.t4.TabIndex = 48;
            this.t4.Tag = "";
            this.t4.Text = "SELECT";
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(320, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 47;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t9
            // 
            this.t9.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t9.Location = new System.Drawing.Point(321, 569);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(254, 40);
            this.t9.TabIndex = 46;
            // 
            // t8
            // 
            this.t8.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t8.Location = new System.Drawing.Point(321, 523);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(254, 40);
            this.t8.TabIndex = 45;
            // 
            // t7
            // 
            this.t7.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7.Location = new System.Drawing.Point(321, 477);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(254, 40);
            this.t7.TabIndex = 44;
            // 
            // t3
            // 
            this.t3.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.Location = new System.Drawing.Point(321, 293);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(254, 40);
            this.t3.TabIndex = 42;
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(320, 247);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(254, 40);
            this.t2.TabIndex = 41;
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(321, 201);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(254, 40);
            this.t1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(152, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 27);
            this.label10.TabIndex = 39;
            this.label10.Text = " Bowling style:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(165, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 27);
            this.label8.TabIndex = 37;
            this.label8.Text = "Batting Style:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(244, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(239, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "DOB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(206, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(220, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(224, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "Player id:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 54;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t6
            // 
            this.t6.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6.Location = new System.Drawing.Point(320, 431);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(254, 40);
            this.t6.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(250, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 56;
            this.label9.Text = "Age:";
            // 
            // t5
            // 
            this.t5.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.Location = new System.Drawing.Point(321, 385);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(254, 40);
            this.t5.TabIndex = 57;
            // 
            // update
            // 
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.images__21_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lat = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text + "-" + t6.Text + "-" + t7.Text + "-" + t8.Text + "-" + t9.Text;
            try
            {


                string str = File.ReadAllText("player.txt");
                str = str.Replace(old, lat);
                File.WriteAllText("player.txt", str);
                MessageBox.Show("records updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            type t = new type();
            t.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            injupdate i = new injupdate();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pid = t1.Text;
            this.Hide();
            careerupdate i = new careerupdate();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void update_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("player.txt");

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
                                t9.Text = a[8];
                                old = t1.Text + "-" + t2.Text + "-" + t3.Text + "-" + t4.Text + "-" + t5.Text + "-" + t6.Text + "-" + t7.Text + "-" + t8.Text + "-" + t9.Text;

                            }

                        }
                    }
                }

            }
            sr.Close();
        }

        private void odiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pid = t1.Text;
            this.Hide();
            odiupdate o = new odiupdate();
            o.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pid = t1.Text;
            this.Hide();
            testupdate t = new testupdate();
            t.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void t20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            t20update t = new t20update();
            t.Show();
        }
    }



}

    

