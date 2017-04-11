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
            LevelNumberMain.Font = new Font("Arial", 24, FontStyle.Bold);


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
            toAdd.NewExits = ExitsToAdd;
            toAdd.RoomTitle = New_Level_Name.Text;
            toAdd.RoomDescription = New_Level_Description.Text;
            toAdd.Inventory = NewItemsToAdd;
            NewLevels.Add(toAdd);
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
                SaveValues(Levels);
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
            private List<NewExits> ExitsToAdd;
            public List<NewItems> NewItemsToAdd;



        }








    }
    }

