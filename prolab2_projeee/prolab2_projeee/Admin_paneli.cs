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

        // Kullanıcı adları ve şifreler için bir Dictionary oluşturun
        Dictionary<string, string> users = new Dictionary<string, string>()
        {
             { "a", "b" },
               // Diğer kullanıcıları buraya ekleyin
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text != string.Empty && passtxt.Text != string.Empty)
            {
                // Kullanıcının var olup olmadığını kontrol edin
                if (users.ContainsKey(usrtxt.Text))
                {
                    // Şifrenin doğru olup olmadığını kontrol edin
                    if (users[usrtxt.Text] == passtxt.Text)
                    {
                        MessageBox.Show("login Admin");

                        // Yeni bir AdminForm oluşturun ve gösterin
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
