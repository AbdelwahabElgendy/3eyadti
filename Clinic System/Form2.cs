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

namespace Clinic_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //    Application.Exit();
            }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int m = 1;
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (m==1)
            textBox1.Text="";
            m++;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (m == 2)
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                m++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "12345")
            {
                this.Hide();
                Form5 frm5 =new Form5();
                frm5.Show();
            }
        }
    }
}
