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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int m = 1;
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (m == 1)
                textBox1.Text = "";
            m++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

          
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
