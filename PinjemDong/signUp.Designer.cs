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
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            loginButton = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(31, 196);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(296, 33);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(31, 286);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(296, 33);
            passwordBox.TabIndex = 1;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(31, 440);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(291, 33);
            emailBox.TabIndex = 2;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(31, 364);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(296, 33);
            NameBox.TabIndex = 3;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // signButton
            // 
            signButton.BackColor = Color.FromArgb(173, 51, 109);
            signButton.ForeColor = Color.White;
            signButton.Location = new Point(121, 496);
            signButton.Name = "signButton";
            signButton.Size = new Size(137, 47);
            signButton.TabIndex = 4;
            signButton.Text = "sign up";
            signButton.UseVisualStyleBackColor = false;
            signButton.Click += signButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(446, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 558);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(102, 102, 102);
            label4.Location = new Point(36, 413);
            label4.Name = "label4";
            label4.Size = new Size(53, 24);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(102, 102, 102);
            label1.Location = new Point(31, 337);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 9;
            label1.Text = "Nama";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(236, 215, 220);
            button2.ForeColor = Color.FromArgb(120, 120, 120);
            button2.Location = new Point(27, 88);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.FromArgb(102, 102, 102);
            loginButton.Location = new Point(173, 88);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 50);
            loginButton.TabIndex = 7;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(84, 14);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 6;
            label5.Text = "PinjemDong!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 102, 102);
            label3.Location = new Point(31, 249);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(102, 102, 102);
            label2.Location = new Point(31, 159);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1178, 619);
            Controls.Add(panel1);
            Name = "signUp";
            Text = "signUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox username;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox emailBox;
        private TextBox NameBox;
        private Button signButton;
        private Panel panel1;
        private Button button2;
        private Button loginButton;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}