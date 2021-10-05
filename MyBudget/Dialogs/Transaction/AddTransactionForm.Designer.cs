
namespace MyBudget.Dialogs
{
    partial class AddTransactionForm
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.RemoveRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.ActionButton);
            this.MainGroup.Controls.Add(this.RemoveRadioButton);
            this.MainGroup.Controls.Add(this.AddRadioButton);
            this.MainGroup.Controls.Add(this.TotalTextBox);
            this.MainGroup.Controls.Add(this.TotalLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(264, 94);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(171, 58);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(80, 23);
            this.ActionButton.TabIndex = 4;
            this.ActionButton.Text = "Выполнить";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // RemoveRadioButton
            // 
            this.RemoveRadioButton.AutoSize = true;
            this.RemoveRadioButton.Location = new System.Drawing.Point(97, 60);
            this.RemoveRadioButton.Name = "RemoveRadioButton";
            this.RemoveRadioButton.Size = new System.Drawing.Size(70, 19);
            this.RemoveRadioButton.TabIndex = 3;
            this.RemoveRadioButton.TabStop = true;
            this.RemoveRadioButton.Text = "Списать";
            this.RemoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Location = new System.Drawing.Point(13, 60);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(83, 19);
            this.AddRadioButton.TabIndex = 2;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Зачислить";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(67, 24);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(184, 23);
            this.TotalTextBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 27);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 15);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Сумма:";
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 116);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTransactionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление операции";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.RadioButton RemoveRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
    }
}