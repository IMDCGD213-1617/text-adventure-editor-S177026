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
            LevelNumberMain.Text = "Level Number:" + levelnumber;
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
                StreamReader file = new StreamReader(path + "\\Levels.xml");
                List<NewLevels> overview = (List<NewLevels>)reader.Deserialize(file);
                for (int o = 0; o < overview.Count; o++)
                {
                    NewLevels currentLevel = overview[o];
                    ReviewNewLevels.AppendText("Level Number : " + currentLevel.LevelNo + "\n\n\r\n Level Name: " + currentLevel.RoomTitle + "\n\n\r\n Level Description: " + currentLevel.RoomDescription + "\n\n\r\n" + "Exits: \n\n\r\n ");
                    for (int p = 0; p < currentLevel.ExitsToAdd.Count; p++)
                    {
                        ReviewNewLevels.AppendText(currentLevel.ExitsToAdd[p].Direction.ToString() + " lead to level " + currentLevel.ExitsToAdd[p].LeadsTo.ToString() + ": \n\n\r\n");
                    }
                    ReviewNewLevels.AppendText("Items :");
                    for (int i = 0; i < currentLevel.inventory.Count; i++)
                    {
                        ReviewNewLevels.AppendText(currentLevel.inventory[i].ItemName);
                    }
                    ReviewNewLevels.AppendText(Environment.NewLine);
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("No Xml File Found");
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
        









    }



    }
    

