﻿namespace PinjemDong
{
    partial class homePage
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            addButton = new Button();
            NameTB = new TextBox();
            label1 = new Label();
            label3 = new Label();
            stockTB = new TextBox();
            k = new Label();
            kategoriTB = new TextBox();
            label4 = new Label();
            hargaTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 51, 109);
            label5.Location = new Point(85, 19);
            label5.Name = "label5";
            label5.Size = new Size(0, 38);
            label5.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1035, 412);
            dataGridView1.TabIndex = 9;
           // dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(1136, 596);
            addButton.Name = "addButton";
            addButton.Size = new Size(198, 71);
            addButton.TabIndex = 10;
            addButton.Text = "Tambah Barang";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(558, 590);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(150, 31);
            NameTB.TabIndex = 11;
            NameTB.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 593);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 12;
            label1.Text = "nama barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 648);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 15;
            label3.Text = "stock";
            // 
            // stockTB
            // 
            stockTB.Location = new Point(558, 648);
            stockTB.Name = "stockTB";
            stockTB.Size = new Size(150, 31);
            stockTB.TabIndex = 16;
            stockTB.TextChanged += stockTB_TextChanged;
            // 
            // k
            // 
            k.AutoSize = true;
            k.Location = new Point(332, 719);
            k.Name = "k";
            k.Size = new Size(77, 25);
            k.TabIndex = 19;
            k.Text = "kategori";
            // 
            // kategoriTB
            // 
            kategoriTB.Location = new Point(558, 713);
            kategoriTB.Name = "kategoriTB";
            kategoriTB.Size = new Size(150, 31);
            kategoriTB.TabIndex = 20;
            kategoriTB.TextChanged += kategoriTB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 784);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 21;
            label4.Text = "harga";
            // 
            // hargaTB
            // 
            hargaTB.Location = new Point(558, 781);
            hargaTB.Name = "hargaTB";
            hargaTB.Size = new Size(150, 31);
            hargaTB.TabIndex = 22;
            hargaTB.TextChanged += hargaTB_TextChanged;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(236, 215, 220);
            ClientSize = new Size(1455, 968);
            Controls.Add(hargaTB);
            Controls.Add(label4);
            Controls.Add(kategoriTB);
            Controls.Add(k);
            Controls.Add(stockTB);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(NameTB);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Name = "homePage";
            Text = "homePage";
            Load += homePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Button addButton;
        private TextBox NameTB;
        private Label label1;
        private Label label3;
        private TextBox stockTB;
        private Label k;
        private TextBox kategoriTB;
        private Label label4;
        private TextBox hargaTB;
    }
}