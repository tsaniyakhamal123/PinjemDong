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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            btn_load = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            panel1 = new Panel();
            filterbtn = new Button();
            productData = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            fotoProduk = new DataGridViewImageColumn();
            harga = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(236, 215, 220);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(12, 22);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 37);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(236, 215, 220);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(916, 7);
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
            pictureBox4.Location = new Point(697, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(213, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.White;
            btn_load.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_load.Location = new Point(828, 626);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(120, 40);
            btn_load.TabIndex = 11;
            btn_load.Text = "Load Data";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(614, 626);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 40);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.White;
            btn_edit.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Location = new Point(396, 626);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(120, 40);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(filterbtn);
            panel1.Controls.Add(productData);
            panel1.Location = new Point(272, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 463);
            panel1.TabIndex = 8;
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
            // 
            // productData
            // 
            productData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productData.BackgroundColor = Color.White;
            productData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productData.Columns.AddRange(new DataGridViewColumn[] { nama, fotoProduk, harga, deskripsi });
            productData.Location = new Point(1, 73);
            productData.Name = "productData";
            productData.RowHeadersWidth = 62;
            productData.RowTemplate.Height = 33;
            productData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productData.Size = new Size(1876, 1014);
            productData.TabIndex = 0;
            productData.CellContentClick += productData_CellContentClick;
            // 
            // nama
            // 
            nama.HeaderText = "Nama Produk";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // fotoProduk
            // 
            fotoProduk.HeaderText = "Foto Produk";
            fotoProduk.MinimumWidth = 20;
            fotoProduk.Name = "fotoProduk";
            fotoProduk.Resizable = DataGridViewTriState.True;
            fotoProduk.SortMode = DataGridViewColumnSortMode.Automatic;
            fotoProduk.Width = 300;
            // 
            // harga
            // 
            harga.HeaderText = "Harga Sewa";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.Width = 150;
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "Deskripsi Produk";
            deskripsi.MinimumWidth = 8;
            deskripsi.Name = "deskripsi";
            deskripsi.Width = 150;
            // 
            // homeAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1142, 691);
            Controls.Add(btn_load);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(backBtn);
            Name = "homeAdmin";
            Text = "homeAdmin";
            Load += homeAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button btn_load;
        private Button btn_delete;
        private Button btn_edit;
        private Panel panel1;
        private Button filterbtn;
        private DataGridView productData;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewImageColumn fotoProduk;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn deskripsi;
    }
}