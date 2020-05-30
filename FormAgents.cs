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
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowClient();
        }

     

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            AgentSet clientSet = new AgentSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleNam.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            Program.wftDb.AgentSet.Add(clientSet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            listAgent.Items.Clear();
            foreach (AgentSet clientsSet in Program.wftDb.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    clientsSet.ID.ToString(), clientsSet.FirstName,clientsSet.
                    MiddleName, clientsSet.LastName, clientsSet.DealShare.ToString() });

                item.Tag = clientsSet;
                listAgent.Items.Add(item);
            }





            listAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void FormAgents_Load(object sender, EventArgs e)
        {

        }

        private void listAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAgent.SelectedItems.Count == 1)
            {
                AgentSet clientsSet = listAgent.SelectedItems[0].Tag as AgentSet;
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleNam.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxDealShare.Text = Convert.ToString(clientsSet.DealShare);
                
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleNam.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
                
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listAgent.SelectedItems.Count == 1)
            {
                AgentSet clientSet = listAgent.SelectedItems[0].Tag as AgentSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleNam.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wftDb.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listAgent.SelectedItems.Count == 1)
                {
                    AgentSet clientSet = listAgent.SelectedItems[0].Tag as AgentSet;
                    Program.wftDb.AgentSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleNam.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDealShare_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDealShare.Text != "") 
            {
                if (Convert.ToInt32(textBoxDealShare.Text)>100)
                {
                    textBoxDealShare.Text = "";
                }
            }
        }

        private void DealShareBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
