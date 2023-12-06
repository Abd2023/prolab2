using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2_projeee
{
    public partial class Admin_paneli : Form
    {
        public Admin_paneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string, string> users = new Dictionary<string, string>()
        {
             { "a", "b" },
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text != string.Empty && passtxt.Text != string.Empty)
            {
                if (users.ContainsKey(usrtxt.Text))
                {
                    if (users[usrtxt.Text] == passtxt.Text)
                    {
                        MessageBox.Show("login Admin");

                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Username & Password");
            }
        }

        private void Admin_paneli_Load(object sender, EventArgs e)
        {

        }
    }
}
