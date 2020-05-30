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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsSet clientSet = new ClientsSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            Program.wftDb.ClientsSet.Add(clientSet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    clientsSet.id.ToString(), clientsSet.FirstName,clientsSet.
                    MiddleName, clientsSet.LastName, clientsSet.Phone, clientsSet.Email });

                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
                                            


         

            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
            private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (listViewClient.SelectedItems.Count ==1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count ==1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count==1)
                {
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.wftDb.ClientsSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
