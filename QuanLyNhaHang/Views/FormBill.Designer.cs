namespace QuanLyNhaHang
{
    partial class FormBill
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
            btnInHoaDon = new Button();
            label1 = new Label();
            label2 = new Label();
            lbTenNhanVien = new Label();
            lbMaHD = new Label();
            label5 = new Label();
            lbNgayLap = new Label();
            label7 = new Label();
            lbBan = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panelChooseType = new Panel();
            cbChooseType = new CheckBox();
            label12 = new Label();
            panelOldType = new Panel();
            label17 = new Label();
            cbbKhachHang = new ComboBox();
            panelNewType = new Panel();
            txtDiaChi = new TextBox();
            label20 = new Label();
            txtSDT = new TextBox();
            label19 = new Label();
            txtTenKH = new TextBox();
            label18 = new Label();
            panelShow = new Panel();
            label15 = new Label();
            lbSDT = new Label();
            label11 = new Label();
            lbTenKH = new Label();
            lbDiaChi = new Label();
            label14 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            btnLuuLai = new Button();
            cbbKhuyenMai = new ComboBox();
            label3 = new Label();
            lbTrangThai = new Label();
            txtTongTien = new Label();
            dgvMon = new DataGridView();
            MaCTHD = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            MaMA = new DataGridViewTextBoxColumn();
            TenMA = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelChooseType.SuspendLayout();
            panelOldType.SuspendLayout();
            panelNewType.SuspendLayout();
            panelShow.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            SuspendLayout();
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(12, 90);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(318, 42);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "IN HÓA ĐƠN";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 60);
            label1.TabIndex = 1;
            label1.Text = "Hóa đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhân viên:";
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Location = new Point(100, 43);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(77, 15);
            lbTenNhanVien.TabIndex = 3;
            lbTenNhanVien.Text = "Lê Văn Thắng";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Location = new Point(100, 16);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(19, 15);
            lbMaHD.TabIndex = 5;
            lbMaHD.Text = "01";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 16);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "Mã hóa đơn:";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Location = new Point(262, 16);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(59, 15);
            lbNgayLap.TabIndex = 7;
            lbNgayLap.Text = "2025-1-20";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 16);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Ngày lập:";
            // 
            // lbBan
            // 
            lbBan.AutoSize = true;
            lbBan.Location = new Point(262, 43);
            lbBan.Name = "lbBan";
            lbBan.Size = new Size(19, 15);
            lbBan.TabIndex = 9;
            lbBan.Text = "01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(192, 43);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Bàn số:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNgayLap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbTenNhanVien);
            panel1.Controls.Add(lbBan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lbMaHD);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 63);
            panel1.TabIndex = 12;
            // 
            // panelChooseType
            // 
            panelChooseType.Controls.Add(cbChooseType);
            panelChooseType.Controls.Add(label12);
            panelChooseType.Dock = DockStyle.Top;
            panelChooseType.Location = new Point(0, 123);
            panelChooseType.Name = "panelChooseType";
            panelChooseType.Size = new Size(342, 29);
            panelChooseType.TabIndex = 13;
            // 
            // cbChooseType
            // 
            cbChooseType.AutoSize = true;
            cbChooseType.Location = new Point(118, 5);
            cbChooseType.Name = "cbChooseType";
            cbChooseType.Size = new Size(113, 19);
            cbChooseType.TabIndex = 1;
            cbChooseType.Text = "Khách hàng mới";
            cbChooseType.UseVisualStyleBackColor = true;
            cbChooseType.CheckedChanged += cbChooseType_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 7);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 0;
            label12.Text = "Khách hàng:";
            // 
            // panelOldType
            // 
            panelOldType.Controls.Add(label17);
            panelOldType.Controls.Add(cbbKhachHang);
            panelOldType.Dock = DockStyle.Top;
            panelOldType.Location = new Point(0, 152);
            panelOldType.Name = "panelOldType";
            panelOldType.Size = new Size(342, 37);
            panelOldType.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 10);
            label17.Name = "label17";
            label17.Size = new Size(47, 15);
            label17.TabIndex = 3;
            label17.Text = "Tên KH:";
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(118, 7);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(203, 23);
            cbbKhachHang.TabIndex = 0;
            // 
            // panelNewType
            // 
            panelNewType.Controls.Add(txtDiaChi);
            panelNewType.Controls.Add(label20);
            panelNewType.Controls.Add(txtSDT);
            panelNewType.Controls.Add(label19);
            panelNewType.Controls.Add(txtTenKH);
            panelNewType.Controls.Add(label18);
            panelNewType.Dock = DockStyle.Top;
            panelNewType.Location = new Point(0, 189);
            panelNewType.Name = "panelNewType";
            panelNewType.Size = new Size(342, 87);
            panelNewType.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(118, 57);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(203, 23);
            txtDiaChi.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(21, 61);
            label20.Name = "label20";
            label20.Size = new Size(46, 15);
            label20.TabIndex = 14;
            label20.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(118, 30);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(203, 23);
            txtSDT.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 34);
            label19.Name = "label19";
            label19.Size = new Size(27, 15);
            label19.TabIndex = 12;
            label19.Text = "SĐT";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(118, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(203, 23);
            txtTenKH.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 7);
            label18.Name = "label18";
            label18.Size = new Size(93, 15);
            label18.TabIndex = 10;
            label18.Text = "Tên khách hàng:";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(label15);
            panelShow.Controls.Add(lbSDT);
            panelShow.Controls.Add(label11);
            panelShow.Controls.Add(lbTenKH);
            panelShow.Controls.Add(lbDiaChi);
            panelShow.Controls.Add(label14);
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 276);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(342, 56);
            panelShow.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(218, 7);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 22;
            label15.Text = "SĐT:";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Location = new Point(261, 7);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(61, 15);
            lbSDT.TabIndex = 17;
            lbSDT.Text = "091399122";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 7);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 18;
            label11.Text = "Tên khách hàng:";
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Location = new Point(119, 7);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(77, 15);
            lbTenKH.TabIndex = 19;
            lbTenKH.Text = "Lê Văn Thắng";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(72, 34);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(77, 15);
            lbDiaChi.TabIndex = 21;
            lbDiaChi.Text = "Lê Văn Thắng";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 34);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 20;
            label14.Text = "Địa chỉ:";
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(btnLuuLai);
            panel6.Controls.Add(cbbKhuyenMai);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lbTrangThai);
            panel6.Controls.Add(txtTongTien);
            panel6.Controls.Add(btnInHoaDon);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 471);
            panel6.Name = "panel6";
            panel6.Size = new Size(342, 140);
            panel6.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 33);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 5;
            label4.Text = "Áp dụng khuyến mãi:";
            // 
            // btnLuuLai
            // 
            btnLuuLai.Location = new Point(12, 90);
            btnLuuLai.Name = "btnLuuLai";
            btnLuuLai.Size = new Size(319, 42);
            btnLuuLai.TabIndex = 7;
            btnLuuLai.Text = "THANH TOÁN";
            btnLuuLai.UseVisualStyleBackColor = true;
            btnLuuLai.Click += btnLuuLai_Click;
            // 
            // cbbKhuyenMai
            // 
            cbbKhuyenMai.FormattingEnabled = true;
            cbbKhuyenMai.Location = new Point(150, 30);
            cbbKhuyenMai.Name = "cbbKhuyenMai";
            cbbKhuyenMai.Size = new Size(180, 23);
            cbbKhuyenMai.TabIndex = 4;
            cbbKhuyenMai.SelectedIndexChanged += cbbKhuyenMai_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 23;
            label3.Text = "TT:";
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(34, 64);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(77, 15);
            lbTrangThai.TabIndex = 24;
            lbTrangThai.Text = "Lê Văn Thắng";
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold | FontStyle.Italic);
            txtTongTien.Location = new Point(150, 62);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(184, 19);
            txtTongTien.TabIndex = 6;
            txtTongTien.Text = "Tổng tiền: 100002312 VNĐ";
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AllowUserToResizeColumns = false;
            dgvMon.AllowUserToResizeRows = false;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { MaCTHD, MaHD, MaMA, TenMA, SoLuong, Gia, DonViTinh });
            dgvMon.Dock = DockStyle.Fill;
            dgvMon.Location = new Point(0, 332);
            dgvMon.Name = "dgvMon";
            dgvMon.RowHeadersVisible = false;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(342, 139);
            dgvMon.TabIndex = 22;
            // 
            // MaCTHD
            // 
            MaCTHD.DataPropertyName = "MaCTHD";
            MaCTHD.HeaderText = "MaCTHD";
            MaCTHD.Name = "MaCTHD";
            MaCTHD.Visible = false;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "MaHD";
            MaHD.Name = "MaHD";
            MaHD.Visible = false;
            // 
            // MaMA
            // 
            MaMA.DataPropertyName = "MaMA";
            MaMA.HeaderText = "MaMA";
            MaMA.Name = "MaMA";
            MaMA.Visible = false;
            // 
            // TenMA
            // 
            TenMA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMA.DataPropertyName = "TenMA";
            TenMA.HeaderText = "Tên Món";
            TenMA.Name = "TenMA";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "SL";
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 44;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "DonGia";
            Gia.HeaderText = "Giá";
            Gia.Name = "Gia";
            // 
            // DonViTinh
            // 
            DonViTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DonViTinh.DataPropertyName = "DVT";
            DonViTinh.HeaderText = "ĐVT";
            DonViTinh.Name = "DonViTinh";
            DonViTinh.Width = 53;
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 611);
            Controls.Add(dgvMon);
            Controls.Add(panel6);
            Controls.Add(panelShow);
            Controls.Add(panelNewType);
            Controls.Add(panelOldType);
            Controls.Add(panelChooseType);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormBill";
            Load += FormBill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelChooseType.ResumeLayout(false);
            panelChooseType.PerformLayout();
            panelOldType.ResumeLayout(false);
            panelOldType.PerformLayout();
            panelNewType.ResumeLayout(false);
            panelNewType.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInHoaDon;
        private Label label1;
        private Label label2;
        private Label lbTenNhanVien;
        private Label lbMaHD;
        private Label label5;
        private Label lbNgayLap;
        private Label label7;
        private Label lbBan;
        private Label label9;
        private Panel panel1;
        private Panel panelChooseType;
        private Label label12;
        private Panel panelOldType;
        private Panel panelNewType;
        private Panel panelShow;
        private Label label15;
        private Label lbSDT;
        private Label label11;
        private Label lbTenKH;
        private Label lbDiaChi;
        private Label label14;
        private Panel panel6;
        private Label txtTongTien;
        private Label label17;
        private ComboBox cbbKhachHang;
        private TextBox txtDiaChi;
        private Label label20;
        private TextBox txtSDT;
        private Label label19;
        private TextBox txtTenKH;
        private Label label18;
        private Button btnLuuLai;
        private DataGridView dgvMon;
        private CheckBox cbChooseType;
        private Label label3;
        private Label lbTrangThai;
        private Label label4;
        private ComboBox cbbKhuyenMai;
        private DataGridViewTextBoxColumn MaCTHD;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn MaMA;
        private DataGridViewTextBoxColumn TenMA;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn DonViTinh;
    }
}