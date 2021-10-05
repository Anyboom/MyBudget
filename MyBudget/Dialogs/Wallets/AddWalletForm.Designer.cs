
namespace MyBudget.Dialogs
{
    partial class AddWalletForm
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
            this.components = new System.ComponentModel.Container();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainList = new System.Windows.Forms.ListBox();
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddWalletMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveWalletMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditWalletMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            this.ListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MainList);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(207, 291);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // MainList
            // 
            this.MainList.ContextMenuStrip = this.ListContextMenu;
            this.MainList.FormattingEnabled = true;
            this.MainList.ItemHeight = 15;
            this.MainList.Location = new System.Drawing.Point(13, 21);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(180, 259);
            this.MainList.TabIndex = 0;
            this.MainList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.MainList_Format);
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWalletMenu,
            this.RemoveWalletMenu,
            this.EditWalletMenu});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // AddWalletMenu
            // 
            this.AddWalletMenu.Name = "AddWalletMenu";
            this.AddWalletMenu.Size = new System.Drawing.Size(180, 22);
            this.AddWalletMenu.Text = "Добавить";
            this.AddWalletMenu.Click += new System.EventHandler(this.AddWalletMenu_Click);
            // 
            // RemoveWalletMenu
            // 
            this.RemoveWalletMenu.Name = "RemoveWalletMenu";
            this.RemoveWalletMenu.Size = new System.Drawing.Size(180, 22);
            this.RemoveWalletMenu.Text = "Удалить";
            this.RemoveWalletMenu.Click += new System.EventHandler(this.RemoveWalletMenu_Click);
            // 
            // EditWalletMenu
            // 
            this.EditWalletMenu.Name = "EditWalletMenu";
            this.EditWalletMenu.Size = new System.Drawing.Size(180, 22);
            this.EditWalletMenu.Text = "Редактировать";
            this.EditWalletMenu.Click += new System.EventHandler(this.EditWalletMenu_Click);
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 315);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WalletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои кошельки";
            this.Load += new System.EventHandler(this.WalletForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.ListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ContextMenuStrip ListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddWalletMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveWalletMenu;
        private System.Windows.Forms.ToolStripMenuItem EditWalletMenu;
    }
}