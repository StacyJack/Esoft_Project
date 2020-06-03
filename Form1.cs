using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labellabelHello.Text = "Приветствую тебя," + FormAuthorization.users.login;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }

        private void buttonPpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formClient = new FormAgents();
            formClient.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstateSet();
            formRealEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form demandSet = new DemandForm();
            demandSet.Show();
        }
    }
}
