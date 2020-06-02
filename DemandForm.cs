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
    public partial class DemandForm : Form
    {
        public DemandForm()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            comboBoxRealEstate.SelectedIndex=0;
            ShowRealEstateSet();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        DemandSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }

                    comboBoxAgent.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                }
                else if (comboBoxRealEstate.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";

                }

            }

            catch
            {
                MessageBox.Show("Невозмсожно удалить, эту запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DemandForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRealEstate.SelectedIndex == 0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                


                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;



                comboBoxAgent.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
            else if (comboBoxRealEstate.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;


                listViewRealEstateSet_Land.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;


                comboBoxAgent.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxRealEstate.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;
                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                comboBoxAgent.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";


            }
        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                string[] item = {agentSet.ID.ToString()+".",agentSet.FirstName, agentSet.MiddleName, agentSet.LastName
                };
                comboBoxAgent.Items.Add(string.Join("", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = {clientsSet.id.ToString()+".",clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName
                };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_Apartment.SelectedItems.Count == 1))
            {
                DemandSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(realEstate.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(realEstate.IdClient.ToString());
                textBoxMinPrice.Text = realEstate.MinPrice.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();
                textBoxMinArea.Text = realEstate.MinArea.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();
                textBoxMinRooms.Text = realEstate.MinRooms.ToString();
                textBoxMaxRooms.Text = realEstate.MaxRooms.ToString();
                textBoxMinFloor.Text = realEstate.MinFloor.ToString();
                textBoxMaxFloor.Text = realEstate.MaxFloor.ToString();
                
            }
            else
            {
                comboBoxAgent.SelectedItem =null ;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";

            }
            
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_House.SelectedItems.Count == 1))
            {
                DemandSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(realEstate.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(realEstate.IdClient.ToString());
                textBoxMinPrice.Text = realEstate.MinPrice.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();
                textBoxMinArea.Text = realEstate.MinArea.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();

                textBoxMinFloors.Text = realEstate.MinFloor.ToString();
                textBoxMaxFloors.Text = realEstate.MaxFloor.ToString();

            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";

                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";

            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_Land.SelectedItems.Count == 1))
            {
                DemandSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(realEstate.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(realEstate.IdClient.ToString());
                textBoxMinPrice.Text = realEstate.MinPrice.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();
                textBoxMinArea.Text = realEstate.MinArea.ToString();
                textBoxMaxPrice.Text = realEstate.MaxPrice.ToString();

            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";


            }

        }
        void ShowRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (DemandSet realEstate in Program.wftDb.DemandSet)
            {
                if (realEstate.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.IdAgent.ToString()+" "+
                        realEstate.AgentSet.LastName+" "+realEstate.AgentSet.FirstName+" "+realEstate.AgentSet.MiddleName,
                        realEstate.IdClient.ToString()+" "+
                        realEstate.ClientsSet.LastName+" "+realEstate.ClientsSet.FirstName+" "+realEstate.ClientsSet.MiddleName,
                        realEstate.MinPrice.ToString(),realEstate.MaxPrice.ToString(),realEstate.MinArea.ToString(),realEstate.MaxArea.ToString(),
                        realEstate.MinRooms.ToString(),realEstate.MaxRooms.ToString(),realEstate.MinFloor.ToString(), realEstate.MaxFloor.ToString()

                    }) ;
                    item.Tag = realEstate;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if (realEstate.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         realEstate.IdAgent.ToString()+" "+
                        realEstate.AgentSet.LastName+" "+realEstate.AgentSet.FirstName+" "+realEstate.AgentSet.MiddleName,
                        realEstate.IdClient.ToString()+" "+
                        realEstate.ClientsSet.LastName+" "+realEstate.ClientsSet.FirstName+" "+realEstate.ClientsSet.MiddleName,
                        realEstate.MinPrice.ToString(),realEstate.MaxPrice.ToString(),realEstate.MinArea.ToString(),realEstate.MaxArea.ToString(),
                        realEstate.MinFloors.ToString(),realEstate.MaxFloors.ToString()
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         realEstate.IdAgent.ToString()+" "+
                        realEstate.AgentSet.LastName+" "+realEstate.AgentSet.FirstName+" "+realEstate.AgentSet.MiddleName,
                        realEstate.IdClient.ToString()+" "+
                        realEstate.ClientsSet.LastName+" "+realEstate.ClientsSet.FirstName+" "+realEstate.ClientsSet.MiddleName,
                        realEstate.MinPrice.ToString(),realEstate.MaxPrice.ToString(),realEstate.MinArea.ToString(),realEstate.MaxArea.ToString(),

                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            {
                DemandSet realEstate = new DemandSet();
                realEstate.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                realEstate.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                realEstate.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                realEstate.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                realEstate.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                realEstate.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                

                if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    realEstate.Type = 0;
                    realEstate.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    realEstate.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    realEstate.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    realEstate.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);

                }
                else if (comboBoxRealEstate.SelectedIndex == 1)
                {
                    realEstate.Type = 1;
                    realEstate.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    realEstate.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                }
                else
                {
                    realEstate.Type = 2;
                }
                Program.wftDb.DemandSet.Add(realEstate);
                Program.wftDb.SaveChanges();
                ShowRealEstateSet();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxRealEstate.SelectedIndex == 0)
            {
                if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                {
                    DemandSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;
                    realEstate.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    realEstate.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    realEstate.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    realEstate.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    realEstate.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    realEstate.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    realEstate.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    realEstate.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    realEstate.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    realEstate.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    realEstate.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    realEstate.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
            else if (comboBoxRealEstate.SelectedIndex == 1)
            {
                if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                {
                    DemandSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;

                    realEstate.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    realEstate.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    realEstate.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    realEstate.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    realEstate.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    realEstate.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    realEstate.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    realEstate.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
            else
            {
                if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                {
                    DemandSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                    realEstate.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    realEstate.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    realEstate.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    realEstate.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    realEstate.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    realEstate.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
        }
    }
}
