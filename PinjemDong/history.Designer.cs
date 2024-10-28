namespace PinjemDong
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            panel1 = new Panel();
            historyTable = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            totalHarga = new DataGridViewTextBoxColumn();
            btnUlasan = new DataGridViewButtonColumn();
            btnReorder = new DataGridViewButtonColumn();
            backBtn = new PictureBox();
            label5 = new Label();
            colorDialog1 = new ColorDialog();
            btnSidebar = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(historyTable);
            panel1.Location = new Point(91, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 559);
            panel1.TabIndex = 8;
            // 
            // historyTable
            // 
            historyTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            historyTable.BackgroundColor = Color.White;
            historyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyTable.Columns.AddRange(new DataGridViewColumn[] { nama, harga, Jumlah, totalHarga, btnUlasan, btnReorder });
            historyTable.Location = new Point(-59, 0);
            historyTable.Name = "historyTable";
            historyTable.RowHeadersWidth = 62;
            historyTable.RowTemplate.Height = 33;
            historyTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            historyTable.Size = new Size(1708, 747);
            historyTable.TabIndex = 0;
            historyTable.CellContentClick += dataAdmin_CellContentClick;
            // 
            // nama
            // 
            nama.HeaderText = "Nama Barang";
            nama.MinimumWidth = 20;
            nama.Name = "nama";
            nama.Resizable = DataGridViewTriState.True;
            nama.Width = 300;
            // 
            // harga
            // 
            harga.HeaderText = "Variasi";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.Width = 150;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 8;
            Jumlah.Name = "Jumlah";
            Jumlah.Width = 150;
            // 
            // totalHarga
            // 
            totalHarga.HeaderText = "Total Harga";
            totalHarga.MinimumWidth = 8;
            totalHarga.Name = "totalHarga";
            totalHarga.Width = 150;
            // 
            // btnUlasan
            // 
            btnUlasan.HeaderText = "Beri Ulasan";
            btnUlasan.MinimumWidth = 8;
            btnUlasan.Name = "btnUlasan";
            btnUlasan.Text = "Beri Ulasan";
            btnUlasan.UseColumnTextForButtonValue = true;
            btnUlasan.Width = 150;
            // 
            // btnReorder
            // 
            btnReorder.HeaderText = "Sewa Lagi";
            btnReorder.MinimumWidth = 8;
            btnReorder.Name = "btnReorder";
            btnReorder.UseColumnTextForButtonValue = true;
            btnReorder.Width = 150;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(21, 19);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 37);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 7;
            backBtn.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(91, 19);
            label5.Name = "label5";
            label5.Size = new Size(189, 38);
            label5.TabIndex = 7;
            label5.Text = "PinjemDong!";
            // 
            // btnSidebar
            // 
            btnSidebar.BackColor = Color.FromArgb(236, 215, 220);
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(12, 82);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(68, 59);
            btnSidebar.TabIndex = 9;
            btnSidebar.UseVisualStyleBackColor = false;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(236, 215, 220);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(12, 569);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(71, 62);
            btnLogout.TabIndex = 10;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1147, 653);
            Controls.Add(btnLogout);
            Controls.Add(btnSidebar);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(backBtn);
            Name = "history";
            Text = "history";
            Load += history_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView historyTable;
        private PictureBox backBtn;
        private Label label5;
        private ColorDialog colorDialog1;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn totalHarga;
        private DataGridViewButtonColumn btnUlasan;
        private DataGridViewButtonColumn btnReorder;
        private Button btnSidebar;
        private Button btnLogout;
    }
}