﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BSLayer;
namespace QuanLyCaPhe
{
    public partial class FormDangNhap : Form
    {
        DangNhap DN = new DangNhap();
        string err;
        public static int MaNV;
       
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (DN.KiemTra(txtTen.Text.Trim(), txtMatKhau.Text.Trim(), ref err, ref MaNV) == true)
            {
                if (txtTen.Text.Trim() == "admin" && txtMatKhau.Text.Trim() == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.ShowDialog();
                    FormManHinhChinh.quyentruycap = QuyenTruyCap.Administrator;
                }
                else
                {
                    FormNhanVien formNhanVien = new FormNhanVien();
                    formNhanVien.ShowDialog();
                    FormManHinhChinh.quyentruycap = QuyenTruyCap.NhanVien;
                }
            }
            MessageBox.Show(err);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                Close();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }
    }
}
