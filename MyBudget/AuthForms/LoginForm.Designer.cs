
namespace MyBudget
{
    partial class LoginForm
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
            this.RegLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.RegLinkLabel);
            this.MainGroup.Controls.Add(this.LoginButton);
            this.MainGroup.Controls.Add(this.PassTextBox);
            this.MainGroup.Controls.Add(this.PassLabel);
            this.MainGroup.Controls.Add(this.LoginTextBox);
            this.MainGroup.Controls.Add(this.LoginLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(246, 158);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Авторизация";
            // 
            // RegLinkLabel
            // 
            this.RegLinkLabel.AutoSize = true;
            this.RegLinkLabel.Location = new System.Drawing.Point(13, 130);
            this.RegLinkLabel.Name = "RegLinkLabel";
            this.RegLinkLabel.Size = new System.Drawing.Size(119, 15);
            this.RegLinkLabel.TabIndex = 5;
            this.RegLinkLabel.TabStop = true;
            this.RegLinkLabel.Text = "Зарегистрироваться";
            this.RegLinkLabel.Click += new System.EventHandler(this.RegLinkLabel_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(160, 126);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(73, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 182);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой бюджет";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.LinkLabel RegLinkLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
    }
}