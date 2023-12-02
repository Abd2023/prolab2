using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prolab2_projeee
{



    public partial class AdminForm : Form
    {
        // Firma bilgilerini saklamak için bir List<Company> koleksiyonu oluşturun
        private List<Company> companies = new List<Company>();

        public AdminForm()
        {
            InitializeComponent();

            // Başlangıçta var olan firmaları oluşturun
            Company companyA = new Company { name = "A", type = "Karayolu", serviceFee = 1000 };
            Company companyB = new Company { name = "B", type = "Karayolu", serviceFee = 1000 };
            Company companyC = new Company { name = "C", type = "Karayolu, Havayolu", serviceFee = 1000 };
            Company companyD = new Company { name = "D", type = "Demiryolu", serviceFee = 1000 };
            Company companyF = new Company { name = "F", type = "Havayolu", serviceFee = 1000 };

            // Bu firmaları companies listesine ekleyin
            companies.Add(companyA);
            companies.Add(companyB);
            companies.Add(companyC);
            companies.Add(companyD);
            companies.Add(companyF);

            // ListView'i güncelleyin
            UpdateListView();
        }

        private void eklebttn_Click(object sender, EventArgs e)
        {
            // Yeni bir Company örneği oluşturun
            Company newCompany = new Company();
            newCompany.name = firma_adi.Text;
            newCompany.type = firma_turu.Text;
            newCompany.serviceFee = decimal.Parse(hizmetBedeli.Text);

            // Yeni Company örneğini koleksiyona ekleyin
            companies.Add(newCompany);

            // ListView'i güncelleyin
            UpdateListView();
        }

        private void UpdateListView()
        {
            // ListView'inizi burada güncelleyin
            listView1.Items.Clear();
            foreach (var company in companies)
            {
                ListViewItem item = new ListViewItem(company.name);
                item.SubItems.Add(company.type);
                item.SubItems.Add(company.serviceFee.ToString());
                listView1.Items.Add(item);
            }
        }

        private void cikartbttn_Click(object sender, EventArgs e)
        {
            // Seçili satırı bulun
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili satırı companies listesinden ve ListView'den silin
                int selectedIndex = listView1.SelectedItems[0].Index;
                companies.RemoveAt(selectedIndex);
                listView1.Items.RemoveAt(selectedIndex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // ben bi yorum satırım
        

    }


}
