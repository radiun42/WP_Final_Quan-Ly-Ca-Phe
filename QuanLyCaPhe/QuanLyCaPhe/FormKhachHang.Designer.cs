﻿namespace QuanLyCaPhe
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.BtXoa = new System.Windows.Forms.Button();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbHKH = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.DgvKH = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbMKH = new System.Windows.Forms.TextBox();
            this.lbKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtXoa
            // 
            this.BtXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtXoa.Image = global::QuanLyCaPhe.Properties.Resources._3Xoa;
            this.BtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtXoa.Location = new System.Drawing.Point(400, 290);
            this.BtXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(62, 33);
            this.BtXoa.TabIndex = 0;
            this.BtXoa.Text = "Xóa";
            this.BtXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtXoa.UseVisualStyleBackColor = true;
            this.BtXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(358, 73);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(151, 20);
            this.dtNgaySinh.TabIndex = 17;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(358, 132);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(175, 20);
            this.tbDiaChi.TabIndex = 12;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(141, 132);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(122, 20);
            this.tbTen.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(358, 106);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(155, 20);
            this.tbSDT.TabIndex = 14;
            // 
            // tbHKH
            // 
            this.tbHKH.Location = new System.Drawing.Point(140, 101);
            this.tbHKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHKH.Name = "tbHKH";
            this.tbHKH.Size = new System.Drawing.Size(122, 20);
            this.tbHKH.TabIndex = 15;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(46, 134);
            this.lbTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(92, 13);
            this.lbTen.TabIndex = 6;
            this.lbTen.Text = "Tên Khách Hàng:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(278, 134);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lbDiaChi.TabIndex = 7;
            this.lbDiaChi.Tag = "";
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(278, 106);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(78, 13);
            this.lbSDT.TabIndex = 8;
            this.lbSDT.Tag = "";
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(46, 106);
            this.lbHo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(87, 13);
            this.lbHo.TabIndex = 9;
            this.lbHo.Text = "Họ Khách Hàng:";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Location = new System.Drawing.Point(278, 73);
            this.lbNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(59, 13);
            this.lbNS.TabIndex = 10;
            this.lbNS.Tag = "";
            this.lbNS.Text = "Ngày Sinh:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(46, 73);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(91, 13);
            this.lbMaKH.TabIndex = 11;
            this.lbMaKH.Text = "Mã Khách Hàng: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.DgvKH);
            this.panel2.Controls.Add(this.BtXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.tbMKH);
            this.panel2.Location = new System.Drawing.Point(29, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 340);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Giới Tính:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.cbGioiTinh.Location = new System.Drawing.Point(112, 108);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 34;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(550, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 33);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(481, 290);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(56, 33);
            this.btnReload.TabIndex = 31;
            this.btnReload.Text = "ReLoad";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(126, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 33);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DgvKH
            // 
            this.DgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKH.Location = new System.Drawing.Point(20, 150);
            this.DgvKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvKH.Name = "DgvKH";
            this.DgvKH.RowTemplate.Height = 28;
            this.DgvKH.Size = new System.Drawing.Size(586, 119);
            this.DgvKH.TabIndex = 18;
            this.DgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKH_CellClick);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::QuanLyCaPhe.Properties.Resources._2Sua;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(303, 290);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 33);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = global::QuanLyCaPhe.Properties.Resources.Luu;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(209, 290);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(60, 33);
            this.btLuu.TabIndex = 0;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::QuanLyCaPhe.Properties.Resources._1Them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(29, 290);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(76, 33);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbMKH
            // 
            this.tbMKH.Location = new System.Drawing.Point(112, 11);
            this.tbMKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMKH.Name = "tbMKH";
            this.tbMKH.ReadOnly = true;
            this.tbMKH.Size = new System.Drawing.Size(122, 20);
            this.tbMKH.TabIndex = 16;
            this.tbMKH.TextChanged += new System.EventHandler(this.tbMKH_TextChanged);
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbKH.Location = new System.Drawing.Point(142, 8);
            this.lbKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(281, 25);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbKH);
            this.panel1.Location = new System.Drawing.Point(29, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 42);
            this.panel1.TabIndex = 5;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 424);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbHKH);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbHo);
            this.Controls.Add(this.lbNS);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKhachHang";
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox tbHKH;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.TextBox tbMKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}