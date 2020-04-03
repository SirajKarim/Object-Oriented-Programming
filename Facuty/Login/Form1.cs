using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string checkUserName = "siraj";
        string checkPassword = "kietlms";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string userPasword = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==checkUserName && textBox2.Text==checkPassword)
            {
                Form2 F2=new Form2();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
