namespace PinjemDong
{
    partial class homeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeAdmin));
            backBtn = new PictureBox();
            panel1 = new Panel();
            filterbtn = new Button();
            dataAdmin = new DataGridView();
            nama = new DataGridViewImageColumn();
            harga = new DataGridViewTextBoxColumn();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            editBtn = new Button();
            deltBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(12, 22);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 37);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(filterbtn);
            panel1.Controls.Add(dataAdmin);
            panel1.Location = new Point(213, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 361);
            panel1.TabIndex = 1;
            // 
            // filterbtn
            // 
            filterbtn.BackColor = Color.FromArgb(228, 183, 183);
            filterbtn.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            filterbtn.ForeColor = SystemColors.ControlDarkDark;
            filterbtn.Location = new Point(54, 12);
            filterbtn.Name = "filterbtn";
            filterbtn.Size = new Size(570, 38);
            filterbtn.TabIndex = 1;
            filterbtn.Text = "filter";
            filterbtn.TextAlign = ContentAlignment.MiddleLeft;
            filterbtn.UseVisualStyleBackColor = false;
            filterbtn.Click += filterbtn_Click;
            // 
            // dataAdmin
            // 
            dataAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAdmin.BackgroundColor = Color.White;
            dataAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAdmin.Columns.AddRange(new DataGridViewColumn[] { nama, harga });
            dataAdmin.Location = new Point(0, 73);
            dataAdmin.Name = "dataAdmin";
            dataAdmin.RowHeadersWidth = 62;
            dataAdmin.RowTemplate.Height = 33;
            dataAdmin.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataAdmin.Size = new Size(660, 288);
            dataAdmin.TabIndex = 0;
            dataAdmin.CellContentClick += dataAdmin_CellContentClick;
            // 
            // nama
            // 
            nama.HeaderText = "nama barang";
            nama.MinimumWidth = 20;
            nama.Name = "nama";
            nama.Resizable = DataGridViewTriState.True;
            nama.SortMode = DataGridViewColumnSortMode.Automatic;
            nama.Width = 300;
            // 
            // harga
            // 
            harga.HeaderText = "harga";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.Width = 150;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(236, 215, 220);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(752, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(533, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(213, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(228, 183, 183);
            editBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(384, 512);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(112, 65);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deltBtn
            // 
            deltBtn.BackColor = Color.FromArgb(228, 183, 183);
            deltBtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deltBtn.Location = new Point(605, 512);
            deltBtn.Name = "deltBtn";
            deltBtn.Size = new Size(112, 65);
            deltBtn.TabIndex = 3;
            deltBtn.Text = "Delete";
            deltBtn.UseVisualStyleBackColor = false;
            // 
            // homeAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(928, 630);
            Controls.Add(deltBtn);
            Controls.Add(pictureBox4);
            Controls.Add(editBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(backBtn);
            Name = "homeAdmin";
            Text = "homeAdmin";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backBtn;
        private Panel panel1;
        private Button filterbtn;
        private DataGridView dataAdmin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button deltBtn;
        private Button editBtn;
        private DataGridViewImageColumn nama;
        private DataGridViewTextBoxColumn harga;
    }
}