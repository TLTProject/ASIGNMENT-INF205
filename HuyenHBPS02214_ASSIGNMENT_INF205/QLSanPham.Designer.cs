namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    partial class frmQLSanPham
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstviewDSSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxthoatform = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.lblTaiAnh = new System.Windows.Forms.Label();
            this.pbxHinhAnh = new System.Windows.Forms.PictureBox();
            this.pbxClear = new System.Windows.Forms.PictureBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdHinhAnh = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxthoatform)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.pbxthoatform);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.gbxThongTin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1024, 700);
            this.panelMain.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstviewDSSP);
            this.groupBox2.Location = new System.Drawing.Point(118, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 275);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // lstviewDSSP
            // 
            this.lstviewDSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstviewDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstviewDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstviewDSSP.Location = new System.Drawing.Point(3, 8);
            this.lstviewDSSP.Name = "lstviewDSSP";
            this.lstviewDSSP.Size = new System.Drawing.Size(784, 261);
            this.lstviewDSSP.TabIndex = 11;
            this.lstviewDSSP.TileSize = new System.Drawing.Size(25, 100);
            this.lstviewDSSP.UseCompatibleStateImageBehavior = false;
            this.lstviewDSSP.View = System.Windows.Forms.View.Details;
            this.lstviewDSSP.SelectedIndexChanged += new System.EventHandler(this.lstviewDSSP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại sản phẩm";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Chi tiết sản phẩm";
            this.columnHeader6.Width = 190;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(352, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 1);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.Sanphamf;
            this.pictureBox1.Location = new System.Drawing.Point(352, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(406, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // pbxthoatform
            // 
            this.pbxthoatform.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.thoatform;
            this.pbxthoatform.Location = new System.Drawing.Point(3, 3);
            this.pbxthoatform.Name = "pbxthoatform";
            this.pbxthoatform.Size = new System.Drawing.Size(20, 20);
            this.pbxthoatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxthoatform.TabIndex = 16;
            this.pbxthoatform.TabStop = false;
            this.pbxthoatform.Click += new System.EventHandler(this.pbxthoatform_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(767, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chỉnh";
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 38);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.fix;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(21, 124);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 38);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = " Cập nhật";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(21, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 38);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "   Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(22, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thoát";
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.lblTaiAnh);
            this.gbxThongTin.Controls.Add(this.pbxHinhAnh);
            this.gbxThongTin.Controls.Add(this.pbxClear);
            this.gbxThongTin.Controls.Add(this.txtChiTiet);
            this.gbxThongTin.Controls.Add(this.txtSL);
            this.gbxThongTin.Controls.Add(this.txtDonGia);
            this.gbxThongTin.Controls.Add(this.cbxLoaiSP);
            this.gbxThongTin.Controls.Add(this.txtTenSP);
            this.gbxThongTin.Controls.Add(this.txtMaSP);
            this.gbxThongTin.Controls.Add(this.label9);
            this.gbxThongTin.Controls.Add(this.label8);
            this.gbxThongTin.Controls.Add(this.label5);
            this.gbxThongTin.Controls.Add(this.label4);
            this.gbxThongTin.Controls.Add(this.label3);
            this.gbxThongTin.Controls.Add(this.label1);
            this.gbxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTin.Location = new System.Drawing.Point(118, 114);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(628, 273);
            this.gbxThongTin.TabIndex = 0;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông tin";
            // 
            // lblTaiAnh
            // 
            this.lblTaiAnh.AutoSize = true;
            this.lblTaiAnh.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTaiAnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblTaiAnh.Location = new System.Drawing.Point(436, 131);
            this.lblTaiAnh.Name = "lblTaiAnh";
            this.lblTaiAnh.Size = new System.Drawing.Size(100, 21);
            this.lblTaiAnh.TabIndex = 14;
            this.lblTaiAnh.Text = "+ Tải ảnh lên";
            this.lblTaiAnh.Click += new System.EventHandler(this.lblTaiAnh_Click);
            // 
            // pbxHinhAnh
            // 
            this.pbxHinhAnh.BackColor = System.Drawing.Color.LavenderBlush;
            this.pbxHinhAnh.Location = new System.Drawing.Point(388, 55);
            this.pbxHinhAnh.Name = "pbxHinhAnh";
            this.pbxHinhAnh.Size = new System.Drawing.Size(196, 178);
            this.pbxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHinhAnh.TabIndex = 11;
            this.pbxHinhAnh.TabStop = false;
            this.pbxHinhAnh.Click += new System.EventHandler(this.pbxHinhAnh_Click);
            // 
            // pbxClear
            // 
            this.pbxClear.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.Action_reload_icon;
            this.pbxClear.Location = new System.Drawing.Point(595, 14);
            this.pbxClear.Name = "pbxClear";
            this.pbxClear.Size = new System.Drawing.Size(25, 25);
            this.pbxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClear.TabIndex = 10;
            this.pbxClear.TabStop = false;
            this.pbxClear.Click += new System.EventHandler(this.pbxClear_Click);
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTiet.Location = new System.Drawing.Point(121, 181);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChiTiet.Size = new System.Drawing.Size(241, 52);
            this.txtChiTiet.TabIndex = 6;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(121, 156);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(121, 131);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(147, 20);
            this.txtDonGia.TabIndex = 4;
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(121, 105);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(147, 21);
            this.cbxLoaiSP.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(121, 80);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(241, 20);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(121, 55);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(147, 20);
            this.txtMaSP.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chi tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxthoatform)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pbxClear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxthoatform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstviewDSSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbxHinhAnh;
        private System.Windows.Forms.OpenFileDialog ofdHinhAnh;
        private System.Windows.Forms.Label lblTaiAnh;
    }
}