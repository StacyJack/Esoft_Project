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
    public partial class FormRealEstateSet : Form
    {
        public FormRealEstateSet()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_House.SelectedItems.Count == 1))
            {
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Adress_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitube.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitube.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxFloor.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex==0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;


                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;


                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex ==1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;


                listViewRealEstateSet_Land.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;


                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex ==2)
            {
                listViewRealEstateSet_Land.Visible = true;
                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";

            }
        }

        private void labelTotalArea_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RealEstateSet realEstate = new RealEstateSet();
            realEstate.Address_City = textBoxAddress_City.Text;
            realEstate.Adress_House = textBoxAddress_House.Text;
            realEstate.Address_Street = textBoxAddress_Street.Text;
            realEstate.Adress_Number = textBoxAddress_Number.Text;
            realEstate.Coordinate_latitube = Convert.ToDouble(textBoxCoordinate_latitude.Text);
            realEstate.Coordinate_longitube = Convert.ToDouble(textBoxCoordinate_longitude.Text);
            realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);

            if (comboBoxType.SelectedIndex ==0)
            {
                realEstate.Type = 0;
                realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
            }
            else if (comboBoxType.SelectedIndex ==1)
            {
                realEstate.Type = 1;
                realEstate.TotalFloosr = Convert.ToInt32(textBoxTotalFloors.Text);
            }
            else
            {
                realEstate.Type = 2;
            }
            Program.wftDb.RealEstateSet.Add(realEstate);
            Program.wftDb.SaveChanges();
            ShowRealEstateSet();
        }
        void ShowRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (RealEstateSet realEstate in Program.wftDb.RealEstateSet)
            {
                if (realEstate.Type ==0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City,realEstate.Address_Street, realEstate.Adress_House,
                        realEstate.Adress_Number,realEstate.Coordinate_latitube.ToString(),
                        realEstate.Coordinate_longitube.ToString(),realEstate.TotalArea.ToString(),
                        realEstate.Rooms.ToString(),realEstate.Floor.ToString()
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if (realEstate.Type ==1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City,realEstate.Address_Street, realEstate.Adress_House,
                        realEstate.Adress_Number,realEstate.Coordinate_latitube.ToString(),
                        realEstate.Coordinate_longitube.ToString(),realEstate.TotalArea.ToString(),
                        realEstate.TotalFloosr.ToString()
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         realEstate.Address_City,realEstate.Address_Street, realEstate.Adress_House,
                        realEstate.Adress_Number,realEstate.Coordinate_latitube.ToString(),
                        realEstate.Coordinate_longitube.ToString(),realEstate.TotalArea.ToString()
                        
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex ==0)
            {
                if (listViewRealEstateSet_Apartment.SelectedItems.Count==1)
                {
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Adress_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Adress_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitube = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitube = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Adress_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Adress_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitube = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitube = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.TotalFloosr = Convert.ToInt32(textBoxTotalFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
            else
            {
                if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Adress_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Adress_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitube = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitube = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_Apartment.SelectedItems.Count == 1))
            {
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Adress_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitube.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitube.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRealEstateSet_Land.SelectedItems.Count == 1))
            {
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Adress_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitube.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitube.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
               
            }  
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxRooms.Text = "";
                    textBoxFloor.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxFloor.Text = "";
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";

                }
                
            }
            
            catch
            {
                MessageBox.Show("Невозмсожно удалить, эту запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
