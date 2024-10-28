namespace PinjemDong
{
    partial class dashboardPemilik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardPemilik));
            btn_delete = new Button();
            btn_edit = new Button();
            panel1 = new Panel();
            filterbtn = new Button();
            productData = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            fotoProduk = new DataGridViewImageColumn();
            harga = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            btn_load = new Button();
            btnLogout = new Button();
            btnSidebar = new Button();
            backBtn = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(228, 183, 183);
            btn_delete.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(461, 562);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 65);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(228, 183, 183);
            btn_edit.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Location = new Point(240, 562);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(112, 65);
            btn_edit.TabIndex = 5;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(filterbtn);
            panel1.Controls.Add(productData);
            panel1.Location = new Point(125, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 463);
            panel1.TabIndex = 4;
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
            productData.Size = new Size(1268, 651);
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
            // btn_load
            // 
            btn_load.BackColor = Color.FromArgb(228, 183, 183);
            btn_load.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_load.Location = new Point(674, 562);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(139, 65);
            btn_load.TabIndex = 7;
            btn_load.Text = "Load Data";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(236, 215, 220);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(17, 565);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(71, 62);
            btnLogout.TabIndex = 13;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSidebar
            // 
            btnSidebar.BackColor = Color.FromArgb(236, 215, 220);
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(17, 78);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(68, 59);
            btnSidebar.TabIndex = 12;
            btnSidebar.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(26, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 37);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 11;
            backBtn.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(125, 15);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 14;
            label5.Text = "PinjemDong!";
            // 
            // dashboardPemilik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(960, 646);
            Controls.Add(label5);
            Controls.Add(btnLogout);
            Controls.Add(btnSidebar);
            Controls.Add(backBtn);
            Controls.Add(btn_load);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(panel1);
            Name = "dashboardPemilik";
            Text = "dashboardPemilik";
            Load += dashboardPemilik_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productData).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_edit;
        private Panel panel1;
        private Button filterbtn;
        private DataGridView productData;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewImageColumn fotoProduk;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn deskripsi;
        private Button btn_load;
        private Button btnLogout;
        private Button btnSidebar;
        private PictureBox backBtn;
        private Label label5;
    }
}