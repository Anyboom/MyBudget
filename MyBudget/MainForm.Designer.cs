
namespace MyBudget
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.мойАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.MainGrid);
            this.MainBox.Location = new System.Drawing.Point(12, 27);
            this.MainBox.Name = "MainBox";
            this.MainBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainBox.Size = new System.Drawing.Size(407, 411);
            this.MainBox.TabIndex = 0;
            this.MainBox.TabStop = false;
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(13, 24);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.Size = new System.Drawing.Size(381, 374);
            this.MainGrid.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мойАккаунтToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenu.Size = new System.Drawing.Size(431, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // мойАккаунтToolStripMenuItem
            // 
            this.мойАккаунтToolStripMenuItem.Name = "мойАккаунтToolStripMenuItem";
            this.мойАккаунтToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.мойАккаунтToolStripMenuItem.Text = "Мой аккаунт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Мой бюджет";
            this.MainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem мойАккаунтToolStripMenuItem;
    }
}

