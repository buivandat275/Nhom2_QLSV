﻿namespace Nhom2_pro
{
    partial class TLH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoay = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.lbl_Loaidichvu = new System.Windows.Forms.Label();
            this.txt_SoSV = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Tieude = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLH);
            this.groupBox1.Controls.Add(this.cbHocKy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btThoay);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.lbl_MaSach);
            this.groupBox1.Controls.Add(this.lbl_MaKH);
            this.groupBox1.Controls.Add(this.lbl_Loaidichvu);
            this.groupBox1.Controls.Add(this.txt_SoSV);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã lớp học";
            // 
            // btThoay
            // 
            this.btThoay.BackColor = System.Drawing.Color.Firebrick;
            this.btThoay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btThoay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoay.Location = new System.Drawing.Point(589, 210);
            this.btThoay.Name = "btThoay";
            this.btThoay.Size = new System.Drawing.Size(121, 53);
            this.btThoay.TabIndex = 46;
            this.btThoay.Text = "Thoát";
            this.btThoay.UseVisualStyleBackColor = false;
            this.btThoay.Click += new System.EventHandler(this.btThoay_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(412, 210);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(121, 53);
            this.btXoa.TabIndex = 45;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Firebrick;
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Location = new System.Drawing.Point(229, 210);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(121, 53);
            this.btSua.TabIndex = 44;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Firebrick;
            this.btThem.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.Location = new System.Drawing.Point(61, 210);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 53);
            this.btThem.TabIndex = 43;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(200, 31);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(201, 34);
            this.cbMonHoc.TabIndex = 42;
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(43, 120);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(143, 26);
            this.lbl_MaSach.TabIndex = 37;
            this.lbl_MaSach.Text = "Số sinh viên";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Location = new System.Drawing.Point(43, 77);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(90, 26);
            this.lbl_MaKH.TabIndex = 37;
            this.lbl_MaKH.Text = "Tên lớp";
            // 
            // lbl_Loaidichvu
            // 
            this.lbl_Loaidichvu.AutoSize = true;
            this.lbl_Loaidichvu.Location = new System.Drawing.Point(43, 34);
            this.lbl_Loaidichvu.Name = "lbl_Loaidichvu";
            this.lbl_Loaidichvu.Size = new System.Drawing.Size(102, 26);
            this.lbl_Loaidichvu.TabIndex = 36;
            this.lbl_Loaidichvu.Text = "Môn học\r\n";
            // 
            // txt_SoSV
            // 
            this.txt_SoSV.Location = new System.Drawing.Point(200, 120);
            this.txt_SoSV.Name = "txt_SoSV";
            this.txt_SoSV.Size = new System.Drawing.Size(201, 32);
            this.txt_SoSV.TabIndex = 39;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(200, 77);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(201, 32);
            this.txt_TenLop.TabIndex = 39;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.74453F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.25547F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Tieude, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.81132F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1017, 38);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lbl_Tieude
            // 
            this.lbl_Tieude.AutoSize = true;
            this.lbl_Tieude.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Tieude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tieude.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Tieude.Location = new System.Drawing.Point(249, 0);
            this.lbl_Tieude.Name = "lbl_Tieude";
            this.lbl_Tieude.Size = new System.Drawing.Size(400, 38);
            this.lbl_Tieude.TabIndex = 2;
            this.lbl_Tieude.Text = "Tạo Lớp Học";
            this.lbl_Tieude.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.388316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.61169F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 630);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvDanhSachLop, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1017, 554);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(3, 313);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowHeadersWidth = 62;
            this.dgvDanhSachLop.RowTemplate.Height = 28;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(1011, 238);
            this.dgvDanhSachLop.TabIndex = 1;
            this.dgvDanhSachLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Học Kỳ";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(672, 81);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(201, 34);
            this.cbHocKy.TabIndex = 51;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(672, 26);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(201, 32);
            this.txtMaLH.TabIndex = 52;
            // 
            // TLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TLH";
            this.Text = "TLH";
            this.Load += new System.EventHandler(this.TLH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoay;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.Label lbl_Loaidichvu;
        private System.Windows.Forms.TextBox txt_SoSV;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Tieude;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.ComboBox cbHocKy;
    }
}