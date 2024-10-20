namespace PinjemDong
{
    partial class login
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            LoginButton = new Button();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(425, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 500);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(120, 120, 120);
            button2.Location = new Point(27, 99);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 8;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(236, 215, 220);
            button1.ForeColor = Color.FromArgb(102, 102, 102);
            button1.Location = new Point(173, 99);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 7;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(80, 15);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 6;
            label5.Text = "PinjemDong!";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(173, 51, 109);
            LoginButton.ForeColor = Color.WhiteSmoke;
            LoginButton.Location = new Point(100, 367);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 50);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(27, 303);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(296, 33);
            PasswordBox.TabIndex = 3;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameBox.Location = new Point(27, 200);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(296, 28);
            UsernameBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 102, 102);
            label3.Location = new Point(27, 270);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(102, 102, 102);
            label2.Location = new Point(27, 168);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1178, 619);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(236, 215, 220);
            Name = "login";
            Text = "login";
            Load += login_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button LoginButton;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}