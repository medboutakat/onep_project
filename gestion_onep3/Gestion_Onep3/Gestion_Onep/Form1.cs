using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Onep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form5 fo = new Form5();
            //fo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string a = txtUserNa.Text;
            string b = txtPas.Text;
            if (a == "meryem")
            {
                if (b == "mery1234")
                {
                    MessageBox.Show("Login is successfull !!");
                    Frm_dem fl = new Frm_dem();
                    fl.Show();
                }
                else
                    MessageBox.Show("Password Incorrect,Try Again");
            }
            else
                MessageBox.Show("UserName Incorrect,Try Again");

        }
    }
}
