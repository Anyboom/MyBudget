
namespace MyBudget
{
    partial class RegistrationForm
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
            this.RPassTextBox = new System.Windows.Forms.TextBox();
            this.RPassLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.RPassTextBox);
            this.MainGroup.Controls.Add(this.RPassLabel);
            this.MainGroup.Controls.Add(this.RegButton);
            this.MainGroup.Controls.Add(this.PassTextBox);
            this.MainGroup.Controls.Add(this.PassLabel);
            this.MainGroup.Controls.Add(this.LoginTextBox);
            this.MainGroup.Controls.Add(this.LoginLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(246, 211);
            this.MainGroup.TabIndex = 1;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Авторизация";
            // 
            // RPassTextBox
            // 
            this.RPassTextBox.Location = new System.Drawing.Point(13, 141);
            this.RPassTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.RPassTextBox.Name = "RPassTextBox";
            this.RPassTextBox.Size = new System.Drawing.Size(220, 23);
            this.RPassTextBox.TabIndex = 7;
            // 
            // RPassLabel
            // 
            this.RPassLabel.AutoSize = true;
            this.RPassLabel.Location = new System.Drawing.Point(13, 123);
            this.RPassLabel.Name = "RPassLabel";
            this.RPassLabel.Size = new System.Drawing.Size(112, 15);
            this.RPassLabel.TabIndex = 6;
            this.RPassLabel.Text = "Повторите пароль:";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(92, 177);
            this.RegButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(141, 23);
            this.RegButton.TabIndex = 4;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(13, 90);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(220, 23);
            this.PassTextBox.TabIndex = 3;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(13, 72);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(52, 15);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(13, 39);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(220, 23);
            this.LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(13, 21);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(44, 15);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 235);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox RPassTextBox;
        private System.Windows.Forms.Label RPassLabel;
    }
}