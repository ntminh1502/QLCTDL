﻿namespace QuanLyCongTyDuLich
{
    partial class FrmBCTourChuaKhoiHanh
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
            this.cboDaKhoiHanh = new System.Windows.Forms.ComboBox();
            this.cboMaPhamVi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhamVi = new System.Windows.Forms.TextBox();
            this.dataGridViewBC1 = new System.Windows.Forms.DataGridView();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhamVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnHienThiBC1 = new System.Windows.Forms.Button();
            this.btnInBC1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtBC1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDaKhoiHanh
            // 
            this.cboDaKhoiHanh.FormattingEnabled = true;
            this.cboDaKhoiHanh.Location = new System.Drawing.Point(248, 67);
            this.cboDaKhoiHanh.Name = "cboDaKhoiHanh";
            this.cboDaKhoiHanh.Size = new System.Drawing.Size(121, 21);
            this.cboDaKhoiHanh.TabIndex = 0;
            // 
            // cboMaPhamVi
            // 
            this.cboMaPhamVi.FormattingEnabled = true;
            this.cboMaPhamVi.Location = new System.Drawing.Point(248, 109);
            this.cboMaPhamVi.Name = "cboMaPhamVi";
            this.cboMaPhamVi.Size = new System.Drawing.Size(121, 21);
            this.cboMaPhamVi.TabIndex = 1;
            this.cboMaPhamVi.TextChanged += new System.EventHandler(this.cboMaPhamVi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đã Khởi Hành";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(144, 109);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(80, 16);
            this.labe.TabIndex = 3;
            this.labe.Text = "Mã Phạm Vi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Phạm Vi";
            // 
            // txtTenPhamVi
            // 
            this.txtTenPhamVi.Location = new System.Drawing.Point(501, 110);
            this.txtTenPhamVi.Name = "txtTenPhamVi";
            this.txtTenPhamVi.Size = new System.Drawing.Size(135, 20);
            this.txtTenPhamVi.TabIndex = 5;
            // 
            // dataGridViewBC1
            // 
            this.dataGridViewBC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.TenTour,
            this.SoNgay,
            this.MaPhamVi,
            this.NgayKhoiHanh});
            this.dataGridViewBC1.Location = new System.Drawing.Point(51, 161);
            this.dataGridViewBC1.Name = "dataGridViewBC1";
            this.dataGridViewBC1.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewBC1.TabIndex = 6;
            // 
            // MaTour
            // 
            this.MaTour.DataPropertyName = "MaTour";
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.Name = "MaTour";
            // 
            // TenTour
            // 
            this.TenTour.DataPropertyName = "TenTour";
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.Name = "TenTour";
            // 
            // SoNgay
            // 
            this.SoNgay.DataPropertyName = "SoNgay";
            this.SoNgay.HeaderText = "Số Ngày";
            this.SoNgay.Name = "SoNgay";
            // 
            // MaPhamVi
            // 
            this.MaPhamVi.DataPropertyName = "MaPhamVi";
            this.MaPhamVi.HeaderText = "Mã Phạm Vi";
            this.MaPhamVi.Name = "MaPhamVi";
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh";
            this.NgayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBatDau.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBatDau.Image = global::QuanLyCongTyDuLich.Properties.Resources.television_copy;
            this.btnBatDau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatDau.Location = new System.Drawing.Point(51, 329);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(107, 33);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnHienThiBC1
            // 
            this.btnHienThiBC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHienThiBC1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiBC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHienThiBC1.Image = global::QuanLyCongTyDuLich.Properties.Resources.preview;
            this.btnHienThiBC1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiBC1.Location = new System.Drawing.Point(196, 329);
            this.btnHienThiBC1.Name = "btnHienThiBC1";
            this.btnHienThiBC1.Size = new System.Drawing.Size(101, 33);
            this.btnHienThiBC1.TabIndex = 8;
            this.btnHienThiBC1.Text = "Hiển Thị";
            this.btnHienThiBC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiBC1.UseVisualStyleBackColor = false;
            this.btnHienThiBC1.Click += new System.EventHandler(this.btnHienThiBC1_Click);
            // 
            // btnInBC1
            // 
            this.btnInBC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInBC1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInBC1.Image = global::QuanLyCongTyDuLich.Properties.Resources.center_alignment;
            this.btnInBC1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBC1.Location = new System.Drawing.Point(337, 329);
            this.btnInBC1.Name = "btnInBC1";
            this.btnInBC1.Size = new System.Drawing.Size(126, 33);
            this.btnInBC1.TabIndex = 9;
            this.btnInBC1.Text = "In Báo Cáo";
            this.btnInBC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBC1.UseVisualStyleBackColor = false;
            this.btnInBC1.Click += new System.EventHandler(this.btnInBC1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Image = global::QuanLyCongTyDuLich.Properties.Resources.close__1_1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(501, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtBC1
            // 
            this.txtBC1.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBC1.Location = new System.Drawing.Point(32, 12);
            this.txtBC1.Name = "txtBC1";
            this.txtBC1.Size = new System.Drawing.Size(604, 33);
            this.txtBC1.TabIndex = 11;
            this.txtBC1.Text = "BÁO CÁO DANH SÁCH TOUR CHƯA KHỞI HÀNH THEO PHẠM VI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTyDuLich.Properties.Resources.paper;
            this.pictureBox1.Location = new System.Drawing.Point(32, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBCTourChuaKhoiHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(650, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBC1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInBC1);
            this.Controls.Add(this.btnHienThiBC1);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.dataGridViewBC1);
            this.Controls.Add(this.txtTenPhamVi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaPhamVi);
            this.Controls.Add(this.cboDaKhoiHanh);
            this.Name = "FrmBCTourChuaKhoiHanh";
            this.Text = "FrmBCTourChuaKhoiHanh";
            this.Load += new System.EventHandler(this.FrmBCTourChuaKhoiHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDaKhoiHanh;
        private System.Windows.Forms.ComboBox cboMaPhamVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhamVi;
        private System.Windows.Forms.DataGridView dataGridViewBC1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnHienThiBC1;
        private System.Windows.Forms.Button btnInBC1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhamVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiHanh;
        private System.Windows.Forms.TextBox txtBC1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}