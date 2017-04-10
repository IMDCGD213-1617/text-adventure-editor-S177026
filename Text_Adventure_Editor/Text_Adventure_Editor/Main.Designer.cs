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
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Drop_Down.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Drop_Down
            // 
            this.Main_Drop_Down.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_Drop_Down.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.locationToolStripMenuItem});
            this.Main_Drop_Down.Location = new System.Drawing.Point(0, 0);
            this.Main_Drop_Down.Name = "Main_Drop_Down";
            this.Main_Drop_Down.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Main_Drop_Down.Size = new System.Drawing.Size(733, 28);
            this.Main_Drop_Down.TabIndex = 0;
            this.Main_Drop_Down.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 408);
            this.Controls.Add(this.Main_Drop_Down);
            this.MainMenuStrip = this.Main_Drop_Down;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_Drop_Down.ResumeLayout(false);
            this.Main_Drop_Down.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_Drop_Down;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
    }
}

