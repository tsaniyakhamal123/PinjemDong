namespace PinjemDong
{
    partial class signUp
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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            NameBox = new TextBox();
            signButton = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(343, 212);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(150, 31);
            usernameBox.TabIndex = 0;
            usernameBox.Text = "username";
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(343, 275);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(150, 31);
            passwordBox.TabIndex = 1;
            passwordBox.Text = "password";
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(343, 151);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(150, 31);
            emailBox.TabIndex = 2;
            emailBox.Text = "email";
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(343, 97);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 31);
            NameBox.TabIndex = 3;
            NameBox.Text = "name";
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // signButton
            // 
            signButton.Location = new Point(343, 373);
            signButton.Name = "signButton";
            signButton.Size = new Size(112, 34);
            signButton.TabIndex = 4;
            signButton.Text = "sign up";
            signButton.UseVisualStyleBackColor = true;
            signButton.Click += signButton_Click;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signButton);
            Controls.Add(NameBox);
            Controls.Add(emailBox);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Name = "signUp";
            Text = "signUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox emailBox;
        private TextBox NameBox;
        private Button signButton;
    }
}