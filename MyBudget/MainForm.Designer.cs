
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
            this.components = new System.ComponentModel.Container();
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.WalletLabel = new System.Windows.Forms.Label();
            this.WalletComboBox = new System.Windows.Forms.ComboBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WalletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TotalWalletStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalWalletValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainContextMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.UpdateTableButton);
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
            // UpdateTableButton
            // 
            this.UpdateTableButton.Location = new System.Drawing.Point(372, 18);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(22, 23);
            this.UpdateTableButton.TabIndex = 7;
            this.UpdateTableButton.Text = "U";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
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
            this.MonthComboBox.Location = new System.Drawing.Point(250, 18);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(116, 23);
            this.MonthComboBox.TabIndex = 6;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(198, 21);
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
            this.WalletComboBox.Size = new System.Drawing.Size(113, 23);
            this.WalletComboBox.TabIndex = 2;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MainGrid.ContextMenuStrip = this.MainContextMenu;
            this.MainGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainGrid.Location = new System.Drawing.Point(13, 47);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(381, 351);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MainGrid_CellFormatting);
            this.MainGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.MainGrid_DataBindingComplete);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTransactionMenuItem,
            this.RemoveTransactionMenuItem});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(127, 48);
            // 
            // AddTransactionMenuItem
            // 
            this.AddTransactionMenuItem.Name = "AddTransactionMenuItem";
            this.AddTransactionMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddTransactionMenuItem.Text = "Добавить";
            this.AddTransactionMenuItem.Click += new System.EventHandler(this.AddTransactionMenuItem_Click);
            // 
            // RemoveTransactionMenuItem
            // 
            this.RemoveTransactionMenuItem.Name = "RemoveTransactionMenuItem";
            this.RemoveTransactionMenuItem.Size = new System.Drawing.Size(126, 22);
            this.RemoveTransactionMenuItem.Text = "Удалить";
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
            this.WalletMenuItem.Name = "WalletMenuItem";
            this.WalletMenuItem.Size = new System.Drawing.Size(158, 22);
            this.WalletMenuItem.Text = "Мои кошельки";
            this.WalletMenuItem.Click += new System.EventHandler(this.WalletMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalWalletStripLabel,
            this.TotalWalletValue});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 449);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(431, 22);
            this.MainStatusStrip.TabIndex = 2;
            // 
            // TotalWalletStripLabel
            // 
            this.TotalWalletStripLabel.Name = "TotalWalletStripLabel";
            this.TotalWalletStripLabel.Size = new System.Drawing.Size(115, 17);
            this.TotalWalletStripLabel.Text = "Всего на кошельке:";
            // 
            // TotalWalletValue
            // 
            this.TotalWalletValue.Name = "TotalWalletValue";
            this.TotalWalletValue.Size = new System.Drawing.Size(13, 17);
            this.TotalWalletValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 471);
            this.Controls.Add(this.MainStatusStrip);
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
            this.MainContextMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
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
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddTransactionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveTransactionMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TotalWalletStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalWalletValue;
    }
}

