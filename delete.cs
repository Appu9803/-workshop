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
    public partial class delete: Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure?","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
               
                this.Hide();
                delete d = new delete();
                d.Show();
                
            }
            else
            {
                MessageBox.Show("delete process cancelled", "tq", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            type t = new type();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string search_text =textBox3.Text;
            string old;
            string n = "";
            StreamReader sr = File.OpenText("index.txt");
            while ((old = sr.ReadLine()) != null)
            {
                if (!old.Contains(search_text))
                {
                    n += old + Environment.NewLine;
                   
                }
               
            }
            MessageBox.Show("deleted", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sr.Close();
            this.Hide();
            type t = new type();
            t.Show();
           
            File.WriteAllText("index.txt", n);
            

        }

        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
