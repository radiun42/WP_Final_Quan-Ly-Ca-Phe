﻿namespace QuanLyCaPhe
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.pn1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbnv = new System.Windows.Forms.ComboBox();
            this.CbKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.BtXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.pn1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Turquoise;
            this.pn1.Controls.Add(this.label1);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(622, 50);
            this.pn1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(208, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số HĐB";
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(92, 17);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(522, 27);
            this.txtma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Bán";
            // 
            // txtngay
            // 
            this.txtngay.CustomFormat = "MM/dd/yyyy";
            this.txtngay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(92, 89);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(227, 27);
            this.txtngay.TabIndex = 8;
            this.txtngay.ValueChanged += new System.EventHandler(this.txtngay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhân Viên";
            // 
            // lbnv
            // 
            this.lbnv.AutoSize = true;
            this.lbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnv.Location = new System.Drawing.Point(206, 53);
            this.lbnv.Name = "lbnv";
            this.lbnv.Size = new System.Drawing.Size(27, 19);
            this.lbnv.TabIndex = 10;
            this.lbnv.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khách Hàng";
            // 
            // Cbnv
            // 
            this.Cbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbnv.FormattingEnabled = true;
            this.Cbnv.Location = new System.Drawing.Point(92, 50);
            this.Cbnv.Name = "Cbnv";
            this.Cbnv.Size = new System.Drawing.Size(108, 27);
            this.Cbnv.TabIndex = 14;
            // 
            // CbKH
            // 
            this.CbKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbKH.FormattingEnabled = true;
            this.CbKH.Location = new System.Drawing.Point(434, 50);
            this.CbKH.Name = "CbKH";
            this.CbKH.Size = new System.Drawing.Size(132, 27);
            this.CbKH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Thành Tiền";
            // 
            // txttt
            // 
            this.txttt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttt.Enabled = false;
            this.txttt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(434, 81);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(162, 27);
            this.txttt.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.BtXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbnv);
            this.panel1.Controls.Add(this.txtngay);
            this.panel1.Controls.Add(this.CbKH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cbnv);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 356);
            this.panel1.TabIndex = 19;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(44, 134);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(550, 122);
            this.dgvHoaDon.TabIndex = 23;
            // 
            // BtXoa
            // 
            this.BtXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtXoa.Image = global::QuanLyCaPhe.Properties.Resources._3Xoa;
            this.BtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtXoa.Location = new System.Drawing.Point(469, 296);
            this.BtXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(61, 33);
            this.BtXoa.TabIndex = 19;
            this.BtXoa.Text = "Xóa";
            this.BtXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::QuanLyCaPhe.Properties.Resources._2Sua;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(350, 296);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 33);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = global::QuanLyCaPhe.Properties.Resources.Luu;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(231, 296);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(60, 33);
            this.btLuu.TabIndex = 21;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::QuanLyCaPhe.Properties.Resources._1Them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(92, 296);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(74, 33);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHoaDon";
            this.Text = "Thông Tin Hóa Đơn";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbnv;
        private System.Windows.Forms.ComboBox CbKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}