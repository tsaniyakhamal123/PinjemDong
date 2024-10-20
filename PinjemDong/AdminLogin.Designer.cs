namespace PinjemDong
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            label4 = new Label();
            LoginButton = new Button();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(181, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 398);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(113, 23);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 5;
            label4.Text = "Admin Log In";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(173, 51, 109);
            LoginButton.ForeColor = Color.WhiteSmoke;
            LoginButton.Location = new Point(124, 307);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(147, 49);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(27, 235);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(296, 33);
            PasswordBox.TabIndex = 3;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameBox.Location = new Point(27, 125);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(296, 28);
            UsernameBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 102, 102);
            label3.Location = new Point(27, 193);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(102, 102, 102);
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(236, 215, 220);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(173, 51, 109);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 1;
            label1.Text = "PinjemDong!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(807, 532);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(236, 215, 220);
            Name = "admin";
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox UsernameBox;
        private Label label3;
        private Label label2;
        private Button LoginButton;
        private TextBox PasswordBox;
        private PictureBox pictureBox1;
        private Label label4;
    }
}