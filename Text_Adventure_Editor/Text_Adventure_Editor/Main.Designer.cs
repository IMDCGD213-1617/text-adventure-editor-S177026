namespace Text_Adventure_Editor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Drop_Down = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Level_Name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.New_Level_Description = new System.Windows.Forms.TextBox();
            this.New_Level_Name = new System.Windows.Forms.TextBox();
            this.New_Level_Items = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.New_Item_Description = new System.Windows.Forms.TextBox();
            this.Item_Des = new System.Windows.Forms.Label();
            this.West_Box = new System.Windows.Forms.CheckBox();
            this.South_Box = new System.Windows.Forms.CheckBox();
            this.East_Box = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.North_Box = new System.Windows.Forms.CheckBox();
            this.Add_Item_To_Level = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.leadsTo4 = new System.Windows.Forms.TextBox();
            this.leadsTo3 = new System.Windows.Forms.TextBox();
            this.leadsTo2 = new System.Windows.Forms.TextBox();
            this.leadsTo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCompleteLevel = new System.Windows.Forms.Button();
            this.LevelNumberMain = new System.Windows.Forms.Label();
            this.ReviewNewLevels = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Main_Drop_Down.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Drop_Down
            // 
            this.Main_Drop_Down.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Drop_Down.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_Drop_Down.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Main_Drop_Down.Location = new System.Drawing.Point(0, 0);
            this.Main_Drop_Down.Name = "Main_Drop_Down";
            this.Main_Drop_Down.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Main_Drop_Down.Size = new System.Drawing.Size(944, 28);
            this.Main_Drop_Down.TabIndex = 0;
            this.Main_Drop_Down.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Level_Name
            // 
            this.Level_Name.AutoSize = true;
            this.Level_Name.ForeColor = System.Drawing.Color.White;
            this.Level_Name.Location = new System.Drawing.Point(9, 34);
            this.Level_Name.Name = "Level_Name";
            this.Level_Name.Size = new System.Drawing.Size(87, 17);
            this.Level_Name.TabIndex = 1;
            this.Level_Name.Text = "Level Name:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(12, 105);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(121, 17);
            this.Description.TabIndex = 3;
            this.Description.Text = "Level Description:";
            // 
            // New_Level_Description
            // 
            this.New_Level_Description.BackColor = System.Drawing.Color.White;
            this.New_Level_Description.ForeColor = System.Drawing.Color.Black;
            this.New_Level_Description.Location = new System.Drawing.Point(12, 125);
            this.New_Level_Description.Multiline = true;
            this.New_Level_Description.Name = "New_Level_Description";
            this.New_Level_Description.Size = new System.Drawing.Size(257, 119);
            this.New_Level_Description.TabIndex = 8;
            // 
            // New_Level_Name
            // 
            this.New_Level_Name.BackColor = System.Drawing.Color.White;
            this.New_Level_Name.ForeColor = System.Drawing.Color.Black;
            this.New_Level_Name.Location = new System.Drawing.Point(12, 54);
            this.New_Level_Name.Multiline = true;
            this.New_Level_Name.Name = "New_Level_Name";
            this.New_Level_Name.Size = new System.Drawing.Size(257, 25);
            this.New_Level_Name.TabIndex = 9;
            // 
            // New_Level_Items
            // 
            this.New_Level_Items.BackColor = System.Drawing.Color.White;
            this.New_Level_Items.ForeColor = System.Drawing.Color.Black;
            this.New_Level_Items.Location = new System.Drawing.Point(549, 54);
            this.New_Level_Items.Multiline = true;
            this.New_Level_Items.Name = "New_Level_Items";
            this.New_Level_Items.Size = new System.Drawing.Size(257, 25);
            this.New_Level_Items.TabIndex = 13;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.ForeColor = System.Drawing.Color.White;
            this.Item_Name.Location = new System.Drawing.Point(546, 34);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 12;
            this.Item_Name.Text = "Item Name:";
            // 
            // New_Item_Description
            // 
            this.New_Item_Description.BackColor = System.Drawing.Color.White;
            this.New_Item_Description.ForeColor = System.Drawing.Color.Black;
            this.New_Item_Description.Location = new System.Drawing.Point(549, 125);
            this.New_Item_Description.Multiline = true;
            this.New_Item_Description.Name = "New_Item_Description";
            this.New_Item_Description.Size = new System.Drawing.Size(257, 119);
            this.New_Item_Description.TabIndex = 14;
            // 
            // Item_Des
            // 
            this.Item_Des.AutoSize = true;
            this.Item_Des.ForeColor = System.Drawing.Color.White;
            this.Item_Des.Location = new System.Drawing.Point(546, 105);
            this.Item_Des.Name = "Item_Des";
            this.Item_Des.Size = new System.Drawing.Size(113, 17);
            this.Item_Des.TabIndex = 15;
            this.Item_Des.Text = "Item Description:";
            // 
            // West_Box
            // 
            this.West_Box.AutoSize = true;
            this.West_Box.ForeColor = System.Drawing.Color.White;
            this.West_Box.Location = new System.Drawing.Point(32, 460);
            this.West_Box.Name = "West_Box";
            this.West_Box.Size = new System.Drawing.Size(62, 21);
            this.West_Box.TabIndex = 26;
            this.West_Box.Text = "West";
            this.West_Box.UseVisualStyleBackColor = true;
            // 
            // South_Box
            // 
            this.South_Box.AutoSize = true;
            this.South_Box.ForeColor = System.Drawing.Color.White;
            this.South_Box.Location = new System.Drawing.Point(32, 406);
            this.South_Box.Name = "South_Box";
            this.South_Box.Size = new System.Drawing.Size(71, 21);
            this.South_Box.TabIndex = 25;
            this.South_Box.Text = "South ";
            this.South_Box.UseVisualStyleBackColor = true;
            // 
            // East_Box
            // 
            this.East_Box.AutoSize = true;
            this.East_Box.ForeColor = System.Drawing.Color.White;
            this.East_Box.Location = new System.Drawing.Point(32, 352);
            this.East_Box.Name = "East_Box";
            this.East_Box.Size = new System.Drawing.Size(58, 21);
            this.East_Box.TabIndex = 24;
            this.East_Box.Text = "East";
            this.East_Box.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Level Directions";
            // 
            // North_Box
            // 
            this.North_Box.AutoSize = true;
            this.North_Box.ForeColor = System.Drawing.Color.White;
            this.North_Box.Location = new System.Drawing.Point(31, 298);
            this.North_Box.Name = "North_Box";
            this.North_Box.Size = new System.Drawing.Size(65, 21);
            this.North_Box.TabIndex = 22;
            this.North_Box.Text = "North";
            this.North_Box.UseVisualStyleBackColor = true;
            // 
            // Add_Item_To_Level
            // 
            this.Add_Item_To_Level.Location = new System.Drawing.Point(812, 187);
            this.Add_Item_To_Level.Name = "Add_Item_To_Level";
            this.Add_Item_To_Level.Size = new System.Drawing.Size(128, 57);
            this.Add_Item_To_Level.TabIndex = 39;
            this.Add_Item_To_Level.Text = "Add Item";
            this.Add_Item_To_Level.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Number Of The Level They Lead To";
            // 
            // leadsTo4
            // 
            this.leadsTo4.Location = new System.Drawing.Point(145, 458);
            this.leadsTo4.Name = "leadsTo4";
            this.leadsTo4.Size = new System.Drawing.Size(62, 22);
            this.leadsTo4.TabIndex = 43;
            // 
            // leadsTo3
            // 
            this.leadsTo3.Location = new System.Drawing.Point(145, 404);
            this.leadsTo3.Name = "leadsTo3";
            this.leadsTo3.Size = new System.Drawing.Size(62, 22);
            this.leadsTo3.TabIndex = 42;
            // 
            // leadsTo2
            // 
            this.leadsTo2.Location = new System.Drawing.Point(145, 350);
            this.leadsTo2.Name = "leadsTo2";
            this.leadsTo2.Size = new System.Drawing.Size(62, 22);
            this.leadsTo2.TabIndex = 41;
            // 
            // leadsTo1
            // 
            this.leadsTo1.Location = new System.Drawing.Point(145, 296);
            this.leadsTo1.Name = "leadsTo1";
            this.leadsTo1.Size = new System.Drawing.Size(62, 22);
            this.leadsTo1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(812, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Add Items Before";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(812, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adding Level";
            // 
            // AddCompleteLevel
            // 
            this.AddCompleteLevel.Location = new System.Drawing.Point(357, 429);
            this.AddCompleteLevel.Name = "AddCompleteLevel";
            this.AddCompleteLevel.Size = new System.Drawing.Size(147, 65);
            this.AddCompleteLevel.TabIndex = 47;
            this.AddCompleteLevel.Text = "Add Level";
            this.AddCompleteLevel.UseVisualStyleBackColor = true;
            this.AddCompleteLevel.Click += new System.EventHandler(this.AddCompleteLevel_Click);
            // 
            // LevelNumberMain
            // 
            this.LevelNumberMain.AutoSize = true;
            this.LevelNumberMain.ForeColor = System.Drawing.Color.White;
            this.LevelNumberMain.Location = new System.Drawing.Point(279, 34);
            this.LevelNumberMain.Name = "LevelNumberMain";
            this.LevelNumberMain.Size = new System.Drawing.Size(100, 17);
            this.LevelNumberMain.TabIndex = 48;
            this.LevelNumberMain.Text = "Level Number:";
            // 
            // ReviewNewLevels
            // 
            this.ReviewNewLevels.BackColor = System.Drawing.Color.White;
            this.ReviewNewLevels.ForeColor = System.Drawing.Color.Black;
            this.ReviewNewLevels.Location = new System.Drawing.Point(675, 332);
            this.ReviewNewLevels.Multiline = true;
            this.ReviewNewLevels.Name = "ReviewNewLevels";
            this.ReviewNewLevels.Size = new System.Drawing.Size(257, 162);
            this.ReviewNewLevels.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(809, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 37);
            this.button3.TabIndex = 50;
            this.button3.Text = "Review Levels";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(944, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReviewNewLevels);
            this.Controls.Add(this.LevelNumberMain);
            this.Controls.Add(this.AddCompleteLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leadsTo4);
            this.Controls.Add(this.leadsTo3);
            this.Controls.Add(this.leadsTo2);
            this.Controls.Add(this.leadsTo1);
            this.Controls.Add(this.Add_Item_To_Level);
            this.Controls.Add(this.West_Box);
            this.Controls.Add(this.South_Box);
            this.Controls.Add(this.East_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.North_Box);
            this.Controls.Add(this.Item_Des);
            this.Controls.Add(this.New_Item_Description);
            this.Controls.Add(this.New_Level_Items);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.New_Level_Name);
            this.Controls.Add(this.New_Level_Description);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Level_Name);
            this.Controls.Add(this.Main_Drop_Down);
            this.MainMenuStrip = this.Main_Drop_Down;
            this.Name = "Main";
            this.Text = "Text Adventure Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_Drop_Down.ResumeLayout(false);
            this.Main_Drop_Down.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_Drop_Down;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label Level_Name;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox New_Level_Description;
        private System.Windows.Forms.TextBox New_Level_Name;
        private System.Windows.Forms.TextBox New_Level_Items;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.TextBox New_Item_Description;
        private System.Windows.Forms.Label Item_Des;
        private System.Windows.Forms.CheckBox West_Box;
        private System.Windows.Forms.CheckBox South_Box;
        private System.Windows.Forms.CheckBox East_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox North_Box;
        private System.Windows.Forms.Button Add_Item_To_Level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox leadsTo4;
        private System.Windows.Forms.TextBox leadsTo3;
        private System.Windows.Forms.TextBox leadsTo2;
        private System.Windows.Forms.TextBox leadsTo1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCompleteLevel;
        private System.Windows.Forms.Label LevelNumberMain;
        private System.Windows.Forms.TextBox ReviewNewLevels;
        private System.Windows.Forms.Button button3;
    }
}

