using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Text_Adventure_Editor
{
    public partial class Main : Form
    {
        public string name;
        public string path;
        int levelnumber = 1;
        bool isAdding;
        List<NewLevels> NewLevelsToAdd = new List<NewLevels>();
        NewLevels toAdd;
        List<NewItems> NewItemsToAdd = new List<NewItems>();
        NewItems toAddItem;
        List<NewExits> ExitsToAdd = new List<NewExits>();

        public Main()
        {
            InitializeComponent();
            LevelNumberMain.Text = "Level:" + levelnumber;
            ReviewNewLevels.ScrollBars = ScrollBars.Vertical;
            LevelNumberMain.Font = new Font("Arial", 15, FontStyle.Bold);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddCompleteLevel_Click(object sender, EventArgs e)
        {
            isAdding = true;
            MessageBox.Show("New Level Added");

            toAdd = new NewLevels();
            toAdd.LevelNo = levelnumber;
            toAdd.ExitsToAdd = ExitsToAdd;
            toAdd.RoomTitle = New_Level_Name.Text;
            toAdd.RoomDescription = New_Level_Description.Text;
            toAdd.inventory = NewItemsToAdd;
            NewLevelsToAdd.Add(toAdd);
            levelnumber++;
            LevelNumberMain.Text = "Level: " + levelnumber;
            ExitsToAdd = new List<NewExits>();
            NewItemsToAdd = new List<NewItems>();
            Clear();
        }
        void Clear()
        {
            North_Box.Checked = false;
            East_Box.Checked = false;
            South_Box.Checked = false;
            West_Box.Checked = false;

            New_Level_Name.Text = "";
            New_Level_Description.Text = "";

            leadsTo1.Text = "";
            leadsTo2.Text = "";
            leadsTo3.Text = "";
            leadsTo4.Text = "";
            isAdding = false;

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveValues(NewLevelsToAdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void SaveValues(List<NewLevels> v)
        {
            path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            XmlSerializer xs = new XmlSerializer(typeof(List<NewLevels>));
            using (FileStream fs = new FileStream(@"" + path + "\\NewLevels.xml", FileMode.Create))
            {
                xs.Serialize(fs, v);
            }
            MessageBox.Show("Saved to " + path + "\\NewLevels.xml");
        }
        public class NewLevels
        {
            private int levelNo;
            private string roomTitle;
            private string roomDescription;
            private List<NewExits> exitsToAdd;
            public List<NewItems> inventory;

            public NewLevels()
            {

            }
            public string RoomTitle
            {
                get
                {
                    return roomTitle;
                }
                set
                {
                    roomTitle = value;
                }
            }
            public string RoomDescription
            {
                get
                {
                    return roomDescription;
                }
                set
                {
                    roomDescription = value;
                }            
            }
            public int LevelNo
            {
                get
                {
                    return levelNo;               
                }
                set
                {
                    levelNo = value;
                }
            }
            public List<NewExits> ExitsToAdd
            {
                get
                {
                    return exitsToAdd;              
                }
                set
                {
                    exitsToAdd = value;
                }
            }
            public List<NewItems> NewItems
            {
                get
                {
                    return inventory;
                }
                set
                {
                    inventory = value;
                }
            }
        }
       public class NewItems
        {
            private string itemName;
            private string itemDescription;

            public NewItems()
            {

            }
            public string ItemName
            {
                get
                {
                    return itemName;
                }
                set
                {
                    itemName = value;
                }
            }
            public string ItemDescription
            {
                get
                {
                    return itemDescription;
                }
                set
                {
                    itemDescription = value;
                }
            }
        }
        public enum Directions
        {
            North, South, East, West
        };
        public class NewExits
        {
            public static string[] shortDirections = { "N", "S", "E", "W" };
            private int leadsTo = 0;
            private Directions direction;
            
            public NewExits()
            {

            } 
            public int LeadsTo
            {
                get
                {
                    return leadsTo;
                }
                set
                {
                    leadsTo = value;
                }
            }
            public Directions Direction
            {
                get
                {
                    return direction;
                }
                set
                {
                    direction = value;
                }
            }
        }
        private void ReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(List<NewLevels>));

                StreamReader file = new StreamReader(path + "\\NewLevels.xml");

                List<NewLevels> overview = (List<NewLevels>)reader.Deserialize(file);

                for (int p = 0; p < overview.Count; p++)
                {
                    NewLevels currentLevel = overview[p];


                    ReviewNewLevels.AppendText("Level Number: " + currentLevel.LevelNo + "\n\n\r\nLevel Name: " + currentLevel.RoomTitle + "\n\n\r\nLevel Description: " + currentLevel.RoomDescription + "\n\n\r\n" +
                        "Exits: \n\n\r\n ");
                    for (int z = 0; z < currentLevel.ExitsToAdd.Count; z++)
                    {
                        ReviewNewLevels.AppendText(currentLevel.ExitsToAdd[z].Direction.ToString() + " leads to level " + currentLevel.ExitsToAdd[z].LeadsTo.ToString() + ": \n\n\r\n");
                    }
                    ReviewNewLevels.AppendText("Items:");
                    for (int s = 0; s < currentLevel.inventory.Count; s++)
                    {
                        ReviewNewLevels.AppendText(currentLevel.inventory[s].ItemName);
                    }

                    ReviewNewLevels.AppendText(Environment.NewLine);

                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("No Xml file found");
            }
        }
        private void North_Box_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            bool hasOnce = false;
            NewExits exitsToAdd = new NewExits();
            if (string.IsNullOrEmpty(leadsTo1.Text))
            {
                North_Box.Checked = false;
                MessageBox.Show("Please input the level number \n this level leads to");
            }
            else if (hasOnce == false && isAdding == false)
            {
                Int32.TryParse(leadsTo1.Text, out n);
                exitsToAdd.LeadsTo = n;
                exitsToAdd.Direction = Directions.North;
                hasOnce = true;
                ExitsToAdd.Add(exitsToAdd);
            }
        }
        private void East_Box_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            bool hasOnce = false;
            NewExits exitsToAdd = new NewExits();
            if (string.IsNullOrEmpty(leadsTo2.Text))
            {
                East_Box.Checked = false;
                MessageBox.Show("Please input the level number \n this level leads to");
            }
            else if(hasOnce == false && isAdding == false)
            {
                Int32.TryParse(leadsTo2.Text, out n);
                exitsToAdd.LeadsTo = n;
                exitsToAdd.Direction = Directions.East;
                hasOnce = true;
                ExitsToAdd.Add(exitsToAdd);
            }
        }
        private void South_Box_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            bool hasOnce = false;
            NewExits exitsToAdd = new NewExits();
            if (string.IsNullOrEmpty(leadsTo3.Text))
            {
                South_Box.Checked = false;
                MessageBox.Show("Please input the level number \n this level leads to");
            }
            else if (hasOnce == false && isAdding == false)
            {
                Int32.TryParse(leadsTo3.Text, out n);
                exitsToAdd.LeadsTo = n;
                exitsToAdd.Direction = Directions.South;
                hasOnce = true;
                ExitsToAdd.Add(exitsToAdd);
            }
        }
        private void West_Box_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            bool hasOnce = false;
            NewExits exitsToAdd = new NewExits();
            if (string.IsNullOrEmpty(leadsTo4.Text))
            {
                West_Box.Checked = false;
                MessageBox.Show("Please input the level number \n this level leads to");
            }
            else if (hasOnce == false && isAdding == false)
            {
                Int32.TryParse(leadsTo4.Text, out n);
                exitsToAdd.LeadsTo = n;
                exitsToAdd.Direction = Directions.West;
                hasOnce = true;
                ExitsToAdd.Add(exitsToAdd);
            }
        }
        private void Add_Item_To_Level_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Added");
            toAddItem = new NewItems();
            toAddItem.ItemName = New_Level_Items.Text;
            toAddItem.ItemDescription = New_Item_Description.Text;
            NewItemsToAdd.Add(toAddItem);
            New_Level_Items.Text = "";
            New_Item_Description.Text = "";
            MessageBox.Show(NewItemsToAdd.Count.ToString() + "Items Added");
        }
    }
    }
    

