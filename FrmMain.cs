using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Functions.connect();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Functions.closeConnect();
            Application.Exit();
        }


        private void báoCáoDSTourChưaKhởiHànhTheoPhạmViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCTourChuaKhoiHanh frmBC1 = new FrmBCTourChuaKhoiHanh();
            frmBC1.ShowDialog();
        }

        private void báoCáo5TourCóSốNgườiĐKNhiềuNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBC3 fbc3 = new FrmBC3();
            fbc3.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBC2 fbc2 = new FrmBC2();
            fbc2.ShowDialog();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy frmdk = new FrmDangKy();
            frmdk.ShowDialog();
        }

        //private void phạmViToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        private void trườngĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTruongDaoTao frmtdt = new FrmTruongDaoTao();
            frmtdt.ShowDialog();
        }

        private void phạmViToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPhamVi frmpv = new FrmPhamVi();
            frmpv.ShowDialog();
        }
    }
}
