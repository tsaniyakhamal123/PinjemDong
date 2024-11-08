namespace PinjemDong
{
    partial class testHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testHomeAdmin));
            backBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            hargaBarang = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(36, 33);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(66, 68);
            backBtn.TabIndex = 1;
            backBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(236, 215, 220);
            deleteBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(516, 45);
            deleteBtn.Margin = new Padding(30, 45, 40, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(84, 75);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.TextAlign = ContentAlignment.BottomCenter;
            deleteBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(236, 215, 220);
            editBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.Location = new Point(372, 45);
            editBtn.Margin = new Padding(90, 45, 30, 3);
            editBtn.Name = "editBtn";
            editBtn.RightToLeft = RightToLeft.No;
            editBtn.Size = new Size(84, 74);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.TextAlign = ContentAlignment.BottomCenter;
            editBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += button2_Click;
            // 
            // hargaBarang
            // 
            hargaBarang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hargaBarang.AutoEllipsis = true;
            hargaBarang.AutoSize = true;
            hargaBarang.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hargaBarang.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            hargaBarang.Location = new Point(280, 124);
            hargaBarang.Margin = new Padding(0);
            hargaBarang.Name = "hargaBarang";
            hargaBarang.Padding = new Padding(1);
            hargaBarang.Size = new Size(2, 26);
            hargaBarang.TabIndex = 2;
            hargaBarang.TextAlign = ContentAlignment.MiddleCenter;
            hargaBarang.Click += hargaBarang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 20);
            pictureBox1.Margin = new Padding(50, 20, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AccessibleRole = AccessibleRole.MenuBar;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(hargaBarang);
            flowLayoutPanel1.Controls.Add(editBtn);
            flowLayoutPanel1.Controls.Add(deleteBtn);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(181, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(644, 395);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 150);
            label1.Margin = new Padding(143, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 50);
            label1.TabIndex = 6;
            label1.Text = "Palu\r\n5000";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // testHomeAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(866, 540);
            Controls.Add(backBtn);
            Controls.Add(flowLayoutPanel1);
            Name = "testHomeAdmin";
            Text = "testHomeAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button backBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Label hargaBarang;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}