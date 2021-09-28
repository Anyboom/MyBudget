
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
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.WalletLabel = new System.Windows.Forms.Label();
            this.WalletComboBox = new System.Windows.Forms.ComboBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WalletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWalletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.MonthComboBox);
            this.MainBox.Controls.Add(this.MonthLabel);
            this.MainBox.Controls.Add(this.WalletLabel);
            this.MainBox.Controls.Add(this.WalletComboBox);
            this.MainBox.Controls.Add(this.MainGrid);
            this.MainBox.Location = new System.Drawing.Point(12, 27);
            this.MainBox.Name = "MainBox";
            this.MainBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainBox.Size = new System.Drawing.Size(407, 411);
            this.MainBox.TabIndex = 0;
            this.MainBox.TabStop = false;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.MonthComboBox.Location = new System.Drawing.Point(278, 18);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(116, 23);
            this.MonthComboBox.TabIndex = 6;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(226, 21);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(46, 15);
            this.MonthLabel.TabIndex = 5;
            this.MonthLabel.Text = "Месяц:";
            // 
            // WalletLabel
            // 
            this.WalletLabel.AutoSize = true;
            this.WalletLabel.Location = new System.Drawing.Point(13, 21);
            this.WalletLabel.Name = "WalletLabel";
            this.WalletLabel.Size = new System.Drawing.Size(60, 15);
            this.WalletLabel.TabIndex = 3;
            this.WalletLabel.Text = "Кошелек:";
            // 
            // WalletComboBox
            // 
            this.WalletComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WalletComboBox.FormattingEnabled = true;
            this.WalletComboBox.Location = new System.Drawing.Point(79, 18);
            this.WalletComboBox.Name = "WalletComboBox";
            this.WalletComboBox.Size = new System.Drawing.Size(141, 23);
            this.WalletComboBox.TabIndex = 2;
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(13, 47);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.Size = new System.Drawing.Size(381, 351);
            this.MainGrid.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenu.Size = new System.Drawing.Size(431, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WalletMenuItem});
            this.AccountMenuItem.Name = "AccountMenuItem";
            this.AccountMenuItem.Size = new System.Drawing.Size(89, 20);
            this.AccountMenuItem.Text = "Мой аккаунт";
            // 
            // WalletMenuItem
            // 
            this.WalletMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWalletMenuItem});
            this.WalletMenuItem.Name = "WalletMenuItem";
            this.WalletMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WalletMenuItem.Text = "Кошелек";
            // 
            // AddWalletMenuItem
            // 
            this.AddWalletMenuItem.Name = "AddWalletMenuItem";
            this.AddWalletMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddWalletMenuItem.Text = "Добавить кошелек";
            this.AddWalletMenuItem.Click += new System.EventHandler(this.AddWalletMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой бюджет";
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label WalletLabel;
        private System.Windows.Forms.ComboBox WalletComboBox;
        private System.Windows.Forms.ToolStripMenuItem WalletMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddWalletMenuItem;
    }
}

