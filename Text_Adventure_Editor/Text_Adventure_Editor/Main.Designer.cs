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
            this.Level_Name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.levelDescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Level_Items = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.Item_Description = new System.Windows.Forms.TextBox();
            this.Item_Des = new System.Windows.Forms.Label();
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
            this.Main_Drop_Down.Size = new System.Drawing.Size(849, 28);
            this.Main_Drop_Down.TabIndex = 0;
            this.Main_Drop_Down.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Level_Name
            // 
            this.Level_Name.AutoSize = true;
            this.Level_Name.ForeColor = System.Drawing.Color.White;
            this.Level_Name.Location = new System.Drawing.Point(9, 47);
            this.Level_Name.Name = "Level_Name";
            this.Level_Name.Size = new System.Drawing.Size(87, 17);
            this.Level_Name.TabIndex = 1;
            this.Level_Name.Text = "Level Name:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(12, 118);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(121, 17);
            this.Description.TabIndex = 3;
            this.Description.Text = "Level Description:";
            // 
            // levelDescription
            // 
            this.levelDescription.BackColor = System.Drawing.Color.White;
            this.levelDescription.ForeColor = System.Drawing.Color.Black;
            this.levelDescription.Location = new System.Drawing.Point(12, 138);
            this.levelDescription.Multiline = true;
            this.levelDescription.Name = "levelDescription";
            this.levelDescription.Size = new System.Drawing.Size(257, 119);
            this.levelDescription.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 25);
            this.textBox1.TabIndex = 9;
            // 
            // Level_Items
            // 
            this.Level_Items.BackColor = System.Drawing.Color.White;
            this.Level_Items.ForeColor = System.Drawing.Color.Black;
            this.Level_Items.Location = new System.Drawing.Point(580, 67);
            this.Level_Items.Multiline = true;
            this.Level_Items.Name = "Level_Items";
            this.Level_Items.Size = new System.Drawing.Size(257, 25);
            this.Level_Items.TabIndex = 13;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.ForeColor = System.Drawing.Color.White;
            this.Item_Name.Location = new System.Drawing.Point(577, 47);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 12;
            this.Item_Name.Text = "Item Name:";
            // 
            // Item_Description
            // 
            this.Item_Description.BackColor = System.Drawing.Color.White;
            this.Item_Description.ForeColor = System.Drawing.Color.Black;
            this.Item_Description.Location = new System.Drawing.Point(580, 138);
            this.Item_Description.Multiline = true;
            this.Item_Description.Name = "Item_Description";
            this.Item_Description.Size = new System.Drawing.Size(257, 119);
            this.Item_Description.TabIndex = 14;
            // 
            // Item_Des
            // 
            this.Item_Des.AutoSize = true;
            this.Item_Des.ForeColor = System.Drawing.Color.White;
            this.Item_Des.Location = new System.Drawing.Point(577, 118);
            this.Item_Des.Name = "Item_Des";
            this.Item_Des.Size = new System.Drawing.Size(113, 17);
            this.Item_Des.TabIndex = 15;
            this.Item_Des.Text = "Item Description:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.Controls.Add(this.Item_Des);
            this.Controls.Add(this.Item_Description);
            this.Controls.Add(this.Level_Items);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.levelDescription);
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
        private System.Windows.Forms.TextBox levelDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Level_Items;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.TextBox Item_Description;
        private System.Windows.Forms.Label Item_Des;
    }
}

