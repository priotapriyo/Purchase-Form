using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchaseform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text;
            pass = password.Text;
            if(user=="Arman" && pass=="180104151")
            {
                this.Hide();
                Purchase p = new Purchase(user,pass);
                p.Show();
            }
            else
            {
                MessageBox.Show("Wrong Information");
                username.Clear();
                password.Clear();
                username.Focus();
            }
        }
    }
}
