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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            label4 = new Label();
            LoginButton = new Button();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(392, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 456);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(236, 215, 220);
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 7);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 5;
            label4.Text = "Admin Log In";
            label4.Click += label4_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(173, 51, 109);
            LoginButton.ForeColor = Color.WhiteSmoke;
            LoginButton.Location = new Point(130, 376);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(147, 49);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(54, 289);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(296, 33);
            PasswordBox.TabIndex = 3;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameBox.Location = new Point(54, 179);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(296, 28);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 102, 102);
            label3.Location = new Point(54, 247);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(102, 102, 102);
            label2.Location = new Point(54, 132);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(104, 7);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 7;
            label5.Text = "PinjemDong!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 215, 220);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(104, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 36);
            panel2.TabIndex = 3;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1178, 619);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(236, 215, 220);
            Name = "admin";
            Text = "AdminLogin";
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox UsernameBox;
        private Label label3;
        private Label label2;
        private Button LoginButton;
        private TextBox PasswordBox;
        private PictureBox pictureBox1;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label label5;
        private Panel panel2;
    }
}