namespace PinjemDong
{
    partial class checkout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            panel3 = new Panel();
            btn_checkout = new Button();
            nominal_total = new Label();
            nominal_biayaLayanan = new Label();
            nominal_ongkir = new Label();
            nominal_subtotal = new Label();
            lbl_total = new Label();
            comboBox_payMethod = new ComboBox();
            lbl_biayaLayanan = new Label();
            lbl_ongkir = new Label();
            lbl_pembayaran = new Label();
            lbl_subtotal = new Label();
            panel2 = new Panel();
            lbl_Harga = new Label();
            lblVariasi = new Label();
            pic_barang = new PictureBox();
            lbl_detailBarang = new Label();
            lbl_namaBarang = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_alamatPengiriman = new Label();
            txt_alamat = new TextBox();
            txt_namaPenerima = new TextBox();
            lbl_alamat = new Label();
            lbl_namaPenerima = new Label();
            lbl_checkout = new Label();
            lbl_PinjemDong = new Label();
            btn_back = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_barang).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_checkout);
            panel3.Controls.Add(nominal_total);
            panel3.Controls.Add(nominal_biayaLayanan);
            panel3.Controls.Add(nominal_ongkir);
            panel3.Controls.Add(nominal_subtotal);
            panel3.Controls.Add(lbl_total);
            panel3.Controls.Add(comboBox_payMethod);
            panel3.Controls.Add(lbl_biayaLayanan);
            panel3.Controls.Add(lbl_ongkir);
            panel3.Controls.Add(lbl_pembayaran);
            panel3.Controls.Add(lbl_subtotal);
            panel3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(210, 585);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 201);
            panel3.TabIndex = 20;
            // 
            // btn_checkout
            // 
            btn_checkout.BackColor = Color.FromArgb(173, 51, 109);
            btn_checkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_checkout.Location = new Point(542, 132);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(209, 53);
            btn_checkout.TabIndex = 19;
            btn_checkout.Text = "Buat Pesanan";
            btn_checkout.UseVisualStyleBackColor = false;
            // 
            // nominal_total
            // 
            nominal_total.AutoSize = true;
            nominal_total.ForeColor = Color.FromArgb(102, 102, 102);
            nominal_total.Location = new Point(208, 161);
            nominal_total.Name = "nominal_total";
            nominal_total.Size = new Size(112, 24);
            nominal_total.TabIndex = 18;
            nominal_total.Text = "Rp.XXX.000";
            // 
            // nominal_biayaLayanan
            // 
            nominal_biayaLayanan.AutoSize = true;
            nominal_biayaLayanan.ForeColor = Color.FromArgb(102, 102, 102);
            nominal_biayaLayanan.Location = new Point(208, 125);
            nominal_biayaLayanan.Name = "nominal_biayaLayanan";
            nominal_biayaLayanan.Size = new Size(86, 24);
            nominal_biayaLayanan.TabIndex = 17;
            nominal_biayaLayanan.Text = "Rp.X.000";
            // 
            // nominal_ongkir
            // 
            nominal_ongkir.AutoSize = true;
            nominal_ongkir.ForeColor = Color.FromArgb(102, 102, 102);
            nominal_ongkir.Location = new Point(208, 90);
            nominal_ongkir.Name = "nominal_ongkir";
            nominal_ongkir.Size = new Size(99, 24);
            nominal_ongkir.TabIndex = 16;
            nominal_ongkir.Text = "Rp.XX.000";
            // 
            // nominal_subtotal
            // 
            nominal_subtotal.AutoSize = true;
            nominal_subtotal.ForeColor = Color.FromArgb(102, 102, 102);
            nominal_subtotal.Location = new Point(208, 55);
            nominal_subtotal.Name = "nominal_subtotal";
            nominal_subtotal.Size = new Size(112, 24);
            nominal_subtotal.TabIndex = 15;
            nominal_subtotal.Text = "Rp.XXX.000";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_total.Location = new Point(26, 161);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(53, 24);
            lbl_total.TabIndex = 14;
            lbl_total.Text = "Total";
            // 
            // comboBox_payMethod
            // 
            comboBox_payMethod.FormattingEnabled = true;
            comboBox_payMethod.Items.AddRange(new object[] { "Transfer Bank", "Virtual Account", "Cash on Delivery" });
            comboBox_payMethod.Location = new Point(416, 13);
            comboBox_payMethod.Name = "comboBox_payMethod";
            comboBox_payMethod.Size = new Size(335, 32);
            comboBox_payMethod.TabIndex = 13;
            comboBox_payMethod.Text = "  Pilih Metode Pembayaran";
            // 
            // lbl_biayaLayanan
            // 
            lbl_biayaLayanan.AutoSize = true;
            lbl_biayaLayanan.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_biayaLayanan.Location = new Point(26, 125);
            lbl_biayaLayanan.Name = "lbl_biayaLayanan";
            lbl_biayaLayanan.Size = new Size(121, 24);
            lbl_biayaLayanan.TabIndex = 7;
            lbl_biayaLayanan.Text = "Biaya Layanan";
            // 
            // lbl_ongkir
            // 
            lbl_ongkir.AutoSize = true;
            lbl_ongkir.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_ongkir.Location = new Point(26, 90);
            lbl_ongkir.Name = "lbl_ongkir";
            lbl_ongkir.Size = new Size(118, 24);
            lbl_ongkir.TabIndex = 6;
            lbl_ongkir.Text = "Ongkos Kirim";
            // 
            // lbl_pembayaran
            // 
            lbl_pembayaran.AutoSize = true;
            lbl_pembayaran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_pembayaran.ForeColor = Color.DimGray;
            lbl_pembayaran.Location = new Point(15, 13);
            lbl_pembayaran.Name = "lbl_pembayaran";
            lbl_pembayaran.Size = new Size(152, 32);
            lbl_pembayaran.TabIndex = 4;
            lbl_pembayaran.Text = "Pembayaran";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_subtotal.Location = new Point(26, 55);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(143, 24);
            lbl_subtotal.TabIndex = 0;
            lbl_subtotal.Text = "Subtotal Produk";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_Harga);
            panel2.Controls.Add(lblVariasi);
            panel2.Controls.Add(pic_barang);
            panel2.Controls.Add(lbl_detailBarang);
            panel2.Controls.Add(lbl_namaBarang);
            panel2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(210, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 201);
            panel2.TabIndex = 19;
            // 
            // lbl_Harga
            // 
            lbl_Harga.AutoSize = true;
            lbl_Harga.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_Harga.Location = new Point(233, 138);
            lbl_Harga.Name = "lbl_Harga";
            lbl_Harga.Size = new Size(202, 24);
            lbl_Harga.TabIndex = 7;
            lbl_Harga.Text = "Jumlah Barang x Harga";
            // 
            // lblVariasi
            // 
            lblVariasi.AutoSize = true;
            lblVariasi.ForeColor = Color.FromArgb(102, 102, 102);
            lblVariasi.Location = new Point(233, 96);
            lblVariasi.Name = "lblVariasi";
            lblVariasi.Size = new Size(66, 24);
            lblVariasi.TabIndex = 6;
            lblVariasi.Text = "Variasi";
            // 
            // pic_barang
            // 
            pic_barang.Image = (Image)resources.GetObject("pic_barang.Image");
            pic_barang.Location = new Point(26, 52);
            pic_barang.Name = "pic_barang";
            pic_barang.Size = new Size(130, 124);
            pic_barang.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_barang.TabIndex = 5;
            pic_barang.TabStop = false;
            // 
            // lbl_detailBarang
            // 
            lbl_detailBarang.AutoSize = true;
            lbl_detailBarang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_detailBarang.ForeColor = Color.DimGray;
            lbl_detailBarang.Location = new Point(15, 13);
            lbl_detailBarang.Name = "lbl_detailBarang";
            lbl_detailBarang.Size = new Size(169, 32);
            lbl_detailBarang.TabIndex = 4;
            lbl_detailBarang.Text = "Detail Barang";
            // 
            // lbl_namaBarang
            // 
            lbl_namaBarang.AutoSize = true;
            lbl_namaBarang.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_namaBarang.Location = new Point(233, 58);
            lbl_namaBarang.Name = "lbl_namaBarang";
            lbl_namaBarang.Size = new Size(118, 24);
            lbl_namaBarang.TabIndex = 0;
            lbl_namaBarang.Text = "Nama Barang";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_alamatPengiriman);
            panel1.Controls.Add(txt_alamat);
            panel1.Controls.Add(txt_namaPenerima);
            panel1.Controls.Add(lbl_alamat);
            panel1.Controls.Add(lbl_namaPenerima);
            panel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(210, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 224);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl_alamatPengiriman
            // 
            lbl_alamatPengiriman.AutoSize = true;
            lbl_alamatPengiriman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_alamatPengiriman.ForeColor = Color.DimGray;
            lbl_alamatPengiriman.Location = new Point(49, 9);
            lbl_alamatPengiriman.Name = "lbl_alamatPengiriman";
            lbl_alamatPengiriman.Size = new Size(233, 32);
            lbl_alamatPengiriman.TabIndex = 4;
            lbl_alamatPengiriman.Text = "Alamat Pengiriman";
            // 
            // txt_alamat
            // 
            txt_alamat.Location = new Point(59, 170);
            txt_alamat.Name = "txt_alamat";
            txt_alamat.Size = new Size(657, 33);
            txt_alamat.TabIndex = 3;
            txt_alamat.UseSystemPasswordChar = true;
            // 
            // txt_namaPenerima
            // 
            txt_namaPenerima.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_namaPenerima.Location = new Point(59, 88);
            txt_namaPenerima.Name = "txt_namaPenerima";
            txt_namaPenerima.Size = new Size(657, 28);
            txt_namaPenerima.TabIndex = 2;
            // 
            // lbl_alamat
            // 
            lbl_alamat.AutoSize = true;
            lbl_alamat.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_alamat.Location = new Point(59, 132);
            lbl_alamat.Name = "lbl_alamat";
            lbl_alamat.Size = new Size(141, 24);
            lbl_alamat.TabIndex = 1;
            lbl_alamat.Text = "Alamat Lengkap";
            // 
            // lbl_namaPenerima
            // 
            lbl_namaPenerima.AutoSize = true;
            lbl_namaPenerima.ForeColor = Color.FromArgb(102, 102, 102);
            lbl_namaPenerima.Location = new Point(59, 54);
            lbl_namaPenerima.Name = "lbl_namaPenerima";
            lbl_namaPenerima.Size = new Size(135, 24);
            lbl_namaPenerima.TabIndex = 0;
            lbl_namaPenerima.Text = "Nama Penerima";
            // 
            // lbl_checkout
            // 
            lbl_checkout.AutoSize = true;
            lbl_checkout.BackColor = Color.Transparent;
            lbl_checkout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_checkout.ForeColor = Color.FromArgb(173, 51, 109);
            lbl_checkout.Location = new Point(523, 52);
            lbl_checkout.Name = "lbl_checkout";
            lbl_checkout.Size = new Size(152, 38);
            lbl_checkout.TabIndex = 17;
            lbl_checkout.Text = "Check Out";
            // 
            // lbl_PinjemDong
            // 
            lbl_PinjemDong.AutoSize = true;
            lbl_PinjemDong.BackColor = Color.WhiteSmoke;
            lbl_PinjemDong.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PinjemDong.ForeColor = Color.FromArgb(173, 51, 109);
            lbl_PinjemDong.Location = new Point(85, 13);
            lbl_PinjemDong.Name = "lbl_PinjemDong";
            lbl_PinjemDong.Size = new Size(189, 38);
            lbl_PinjemDong.TabIndex = 15;
            lbl_PinjemDong.Text = "PinjemDong!";
            // 
            // btn_back
            // 
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(15, 13);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(45, 45);
            btn_back.SizeMode = PictureBoxSizeMode.Zoom;
            btn_back.TabIndex = 16;
            btn_back.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1178, 798);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_checkout);
            Controls.Add(lbl_PinjemDong);
            Controls.Add(btn_back);
            Name = "checkout";
            Text = "checkout";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_barang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btn_checkout;
        private Label nominal_total;
        private Label nominal_biayaLayanan;
        private Label nominal_ongkir;
        private Label nominal_subtotal;
        private Label lbl_total;
        private ComboBox comboBox_payMethod;
        private Label lbl_biayaLayanan;
        private Label lbl_ongkir;
        private Label lbl_pembayaran;
        private Label lbl_subtotal;
        private Panel panel2;
        private Label lbl_Harga;
        private Label lblVariasi;
        private PictureBox pic_barang;
        private Label lbl_detailBarang;
        private Label lbl_namaBarang;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_alamatPengiriman;
        private TextBox txt_alamat;
        private TextBox txt_namaPenerima;
        private Label lbl_alamat;
        private Label lbl_namaPenerima;
        private Label lbl_checkout;
        private Label lbl_PinjemDong;
        private PictureBox btn_back;
        private ContextMenuStrip contextMenuStrip1;
    }
}