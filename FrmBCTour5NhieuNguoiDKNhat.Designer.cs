﻿namespace QuanLyCongTyDuLich
{
    partial class FrmBC3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewBC3 = new System.Windows.Forms.DataGridView();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiDKTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienThiBC3 = new System.Windows.Forms.Button();
            this.btnInBC3 = new System.Windows.Forms.Button();
            this.btnThoatBC3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "BÁO CÁO 5 TOUR CÓ SỐ NGƯỜI ĐK LỚN NHẤT";
            // 
            // dataGridViewBC3
            // 
            this.dataGridViewBC3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBC3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.TenTour,
            this.MaCongTy,
            this.SoNguoiDKTour});
            this.dataGridViewBC3.Location = new System.Drawing.Point(44, 134);
            this.dataGridViewBC3.Name = "dataGridViewBC3";
            this.dataGridViewBC3.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewBC3.TabIndex = 1;
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
            // MaCongTy
            // 
            this.MaCongTy.DataPropertyName = "MaCongTy";
            this.MaCongTy.HeaderText = "Mã Công Ty";
            this.MaCongTy.Name = "MaCongTy";
            // 
            // SoNguoiDKTour
            // 
            this.SoNguoiDKTour.DataPropertyName = "SoNguoiDKTour";
            this.SoNguoiDKTour.HeaderText = "Số Người ĐK Tour";
            this.SoNguoiDKTour.Name = "SoNguoiDKTour";
            // 
            // btnHienThiBC3
            // 
            this.btnHienThiBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHienThiBC3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHienThiBC3.Image = global::QuanLyCongTyDuLich.Properties.Resources.preview;
            this.btnHienThiBC3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiBC3.Location = new System.Drawing.Point(44, 301);
            this.btnHienThiBC3.Name = "btnHienThiBC3";
            this.btnHienThiBC3.Size = new System.Drawing.Size(107, 30);
            this.btnHienThiBC3.TabIndex = 2;
            this.btnHienThiBC3.Text = "Hiển Thị";
            this.btnHienThiBC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiBC3.UseVisualStyleBackColor = false;
            this.btnHienThiBC3.Click += new System.EventHandler(this.btnHienThiBC3_Click);
            // 
            // btnInBC3
            // 
            this.btnInBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInBC3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInBC3.Image = global::QuanLyCongTyDuLich.Properties.Resources.center_alignment;
            this.btnInBC3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBC3.Location = new System.Drawing.Point(210, 301);
            this.btnInBC3.Name = "btnInBC3";
            this.btnInBC3.Size = new System.Drawing.Size(127, 30);
            this.btnInBC3.TabIndex = 3;
            this.btnInBC3.Text = "In Báo Cáo";
            this.btnInBC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBC3.UseVisualStyleBackColor = false;
            this.btnInBC3.Click += new System.EventHandler(this.btnInBC3_Click);
            // 
            // btnThoatBC3
            // 
            this.btnThoatBC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoatBC3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatBC3.Image = global::QuanLyCongTyDuLich.Properties.Resources.close__1_;
            this.btnThoatBC3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatBC3.Location = new System.Drawing.Point(405, 301);
            this.btnThoatBC3.Name = "btnThoatBC3";
            this.btnThoatBC3.Size = new System.Drawing.Size(82, 30);
            this.btnThoatBC3.TabIndex = 4;
            this.btnThoatBC3.Text = "Thoát";
            this.btnThoatBC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatBC3.UseVisualStyleBackColor = false;
            this.btnThoatBC3.Click += new System.EventHandler(this.btnThoatBC3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTyDuLich.Properties.Resources.ranking;
            this.pictureBox1.Location = new System.Drawing.Point(163, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBC3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoatBC3);
            this.Controls.Add(this.btnInBC3);
            this.Controls.Add(this.btnHienThiBC3);
            this.Controls.Add(this.dataGridViewBC3);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmBC3";
            this.Text = "FrmBCTour5NhieuNguoiDKNhat";
            this.Load += new System.EventHandler(this.FrmBC3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewBC3;
        private System.Windows.Forms.Button btnHienThiBC3;
        private System.Windows.Forms.Button btnInBC3;
        private System.Windows.Forms.Button btnThoatBC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiDKTour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}