namespace QuanLyNhaHang
{
    partial class FormQuanLyBanAn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panelCTBanAn = new Panel();
            panelDsMon = new Panel();
            dgvMon = new DataGridView();
            panelCTMon = new Panel();
            cbbMon = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            label4 = new Label();
            lbDVT = new Label();
            lbGiaMon = new Label();
            nbrSoluong = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            btnXoa = new Button();
            btnLuu = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            btnThemMon = new Button();
            button5 = new Button();
            panelThanhToan = new Panel();
            txtTongTien = new Label();
            btnThanhToan = new Button();
            panelGoiMon = new Panel();
            btnGoiMon = new Button();
            panel3 = new Panel();
            btClose = new Guna.UI2.WinForms.Guna2Button();
            btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            txtTenBan = new Label();
            panel2 = new Panel();
            btnThemBanAn = new Guna.UI2.WinForms.Guna2Button();
            panelBan = new FlowLayoutPanel();
            MaCTHD = new DataGridViewTextBoxColumn();
            MaMA = new DataGridViewTextBoxColumn();
            TenMA = new DataGridViewTextBoxColumn();
            MaHD = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            panelCTBanAn.SuspendLayout();
            panelDsMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            panelCTMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrSoluong).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panelThanhToan.SuspendLayout();
            panelGoiMon.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Magenta;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 73);
            label1.TabIndex = 0;
            label1.Text = "     DANH SÁCH BÀN ĂN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCTBanAn
            // 
            panelCTBanAn.BackColor = SystemColors.ActiveCaption;
            panelCTBanAn.Controls.Add(panelDsMon);
            panelCTBanAn.Controls.Add(panelThanhToan);
            panelCTBanAn.Controls.Add(panelGoiMon);
            panelCTBanAn.Controls.Add(panel3);
            panelCTBanAn.Dock = DockStyle.Right;
            panelCTBanAn.Location = new Point(378, 0);
            panelCTBanAn.Name = "panelCTBanAn";
            panelCTBanAn.Size = new Size(370, 468);
            panelCTBanAn.TabIndex = 1;
            panelCTBanAn.Visible = false;
            // 
            // panelDsMon
            // 
            panelDsMon.Controls.Add(dgvMon);
            panelDsMon.Controls.Add(panelCTMon);
            panelDsMon.Controls.Add(panel7);
            panelDsMon.Dock = DockStyle.Fill;
            panelDsMon.Location = new Point(0, 73);
            panelDsMon.Name = "panelDsMon";
            panelDsMon.Size = new Size(370, 309);
            panelDsMon.TabIndex = 8;
            panelDsMon.Visible = false;
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AllowUserToResizeColumns = false;
            dgvMon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 174, 83);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.BorderStyle = BorderStyle.None;
            dgvMon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { MaCTHD, MaMA, TenMA, MaHD, SoLuong, Gia, DonViTinh });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(218, 228, 139);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMon.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMon.Dock = DockStyle.Fill;
            dgvMon.EnableHeadersVisualStyles = false;
            dgvMon.Location = new Point(0, 0);
            dgvMon.Name = "dgvMon";
            dgvMon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(218, 228, 139);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(218, 228, 139);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMon.RowHeadersVisible = false;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(370, 202);
            dgvMon.TabIndex = 11;
            dgvMon.Click += dgvMon_Click;
            // 
            // panelCTMon
            // 
            panelCTMon.BackColor = Color.Lavender;
            panelCTMon.Controls.Add(cbbMon);
            panelCTMon.Controls.Add(label5);
            panelCTMon.Controls.Add(label4);
            panelCTMon.Controls.Add(lbDVT);
            panelCTMon.Controls.Add(lbGiaMon);
            panelCTMon.Controls.Add(nbrSoluong);
            panelCTMon.Controls.Add(label3);
            panelCTMon.Controls.Add(label2);
            panelCTMon.Controls.Add(btnXoa);
            panelCTMon.Controls.Add(btnLuu);
            panelCTMon.Dock = DockStyle.Bottom;
            panelCTMon.Location = new Point(0, 202);
            panelCTMon.Name = "panelCTMon";
            panelCTMon.Size = new Size(370, 64);
            panelCTMon.TabIndex = 10;
            panelCTMon.Visible = false;
            // 
            // cbbMon
            // 
            cbbMon.BackColor = Color.Transparent;
            cbbMon.BorderRadius = 6;
            cbbMon.CustomizableEdges = customizableEdges1;
            cbbMon.DrawMode = DrawMode.OwnerDrawFixed;
            cbbMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMon.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbMon.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbMon.Font = new Font("Segoe UI", 10F);
            cbbMon.ForeColor = Color.FromArgb(68, 88, 112);
            cbbMon.ItemHeight = 18;
            cbbMon.Location = new Point(68, 12);
            cbbMon.Name = "cbbMon";
            cbbMon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbbMon.Size = new Size(166, 24);
            cbbMon.TabIndex = 0;
            cbbMon.SelectedIndexChanged += cbbMon_SelectedIndexChanged;
            cbbMon.SelectedValueChanged += cbbMon_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 42);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "ĐVT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 42);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "Giá:";
            // 
            // lbDVT
            // 
            lbDVT.AutoSize = true;
            lbDVT.Location = new Point(264, 42);
            lbDVT.Name = "lbDVT";
            lbDVT.Size = new Size(31, 15);
            lbDVT.TabIndex = 8;
            lbDVT.Text = "ĐVT:";
            // 
            // lbGiaMon
            // 
            lbGiaMon.AutoSize = true;
            lbGiaMon.Location = new Point(93, 42);
            lbGiaMon.Name = "lbGiaMon";
            lbGiaMon.Size = new Size(27, 15);
            lbGiaMon.TabIndex = 7;
            lbGiaMon.Text = "Giá:";
            // 
            // nbrSoluong
            // 
            nbrSoluong.Location = new Point(300, 12);
            nbrSoluong.Name = "nbrSoluong";
            nbrSoluong.Size = new Size(64, 23);
            nbrSoluong.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 16);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên món:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(7, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 23);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(300, 38);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(64, 23);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button5);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 266);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 43);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Lavender;
            panel8.Controls.Add(btnThemMon);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(370, 43);
            panel8.TabIndex = 9;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(7, 3);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(355, 34);
            btnThemMon.TabIndex = 0;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // button5
            // 
            button5.Location = new Point(193, 3);
            button5.Name = "button5";
            button5.Size = new Size(100, 34);
            button5.TabIndex = 0;
            button5.Text = "Lưu lại";
            button5.UseVisualStyleBackColor = true;
            // 
            // panelThanhToan
            // 
            panelThanhToan.BackColor = Color.Lavender;
            panelThanhToan.Controls.Add(txtTongTien);
            panelThanhToan.Controls.Add(btnThanhToan);
            panelThanhToan.Dock = DockStyle.Bottom;
            panelThanhToan.Location = new Point(0, 382);
            panelThanhToan.Name = "panelThanhToan";
            panelThanhToan.Size = new Size(370, 43);
            panelThanhToan.TabIndex = 7;
            panelThanhToan.Visible = false;
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold | FontStyle.Italic);
            txtTongTien.Location = new Point(10, 12);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(184, 19);
            txtTongTien.TabIndex = 5;
            txtTongTien.Text = "Tổng tiền: 100002312 VNĐ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(262, 5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(100, 34);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // panelGoiMon
            // 
            panelGoiMon.BackColor = Color.Lavender;
            panelGoiMon.Controls.Add(btnGoiMon);
            panelGoiMon.Dock = DockStyle.Bottom;
            panelGoiMon.Location = new Point(0, 425);
            panelGoiMon.Name = "panelGoiMon";
            panelGoiMon.Size = new Size(370, 43);
            panelGoiMon.TabIndex = 5;
            // 
            // btnGoiMon
            // 
            btnGoiMon.Location = new Point(10, 3);
            btnGoiMon.Name = "btnGoiMon";
            btnGoiMon.Size = new Size(352, 34);
            btnGoiMon.TabIndex = 0;
            btnGoiMon.Text = "GỌI MÓN";
            btnGoiMon.UseVisualStyleBackColor = true;
            btnGoiMon.Click += btnGoiMon_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btnThongTin);
            panel3.Controls.Add(txtTenBan);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 73);
            panel3.TabIndex = 4;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.AutoRoundedCorners = true;
            btClose.CustomizableEdges = customizableEdges3;
            btClose.DisabledState.BorderColor = Color.DarkGray;
            btClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btClose.FillColor = Color.Tomato;
            btClose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(325, 18);
            btClose.Name = "btClose";
            btClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btClose.Size = new Size(33, 33);
            btClose.TabIndex = 4;
            btClose.Text = "X";
            btClose.Click += btnClose_Click;
            // 
            // btnThongTin
            // 
            btnThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThongTin.AutoRoundedCorners = true;
            btnThongTin.CustomizableEdges = customizableEdges5;
            btnThongTin.DefaultAutoSize = true;
            btnThongTin.DisabledState.BorderColor = Color.DarkGray;
            btnThongTin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThongTin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThongTin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThongTin.FillColor = Color.DodgerBlue;
            btnThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongTin.ForeColor = Color.White;
            btnThongTin.Location = new Point(218, 18);
            btnThongTin.Name = "btnThongTin";
            btnThongTin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnThongTin.Size = new Size(101, 33);
            btnThongTin.TabIndex = 3;
            btnThongTin.Text = "Thông tin";
            btnThongTin.Click += buttonThongTin_Click;
            // 
            // txtTenBan
            // 
            txtTenBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTenBan.AutoSize = true;
            txtTenBan.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenBan.ForeColor = Color.Orange;
            txtTenBan.Location = new Point(10, 26);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(71, 25);
            txtTenBan.TabIndex = 1;
            txtTenBan.Text = "BÀN 1";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThemBanAn);
            panel2.Controls.Add(panelBan);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 468);
            panel2.TabIndex = 2;
            // 
            // btnThemBanAn
            // 
            btnThemBanAn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemBanAn.AutoRoundedCorners = true;
            btnThemBanAn.BackColor = Color.Magenta;
            btnThemBanAn.CustomizableEdges = customizableEdges7;
            btnThemBanAn.DefaultAutoSize = true;
            btnThemBanAn.DisabledState.BorderColor = Color.DarkGray;
            btnThemBanAn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemBanAn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemBanAn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemBanAn.FillColor = Color.SeaGreen;
            btnThemBanAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemBanAn.ForeColor = Color.White;
            btnThemBanAn.Location = new Point(185, 18);
            btnThemBanAn.Name = "btnThemBanAn";
            btnThemBanAn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThemBanAn.Size = new Size(174, 33);
            btnThemBanAn.TabIndex = 2;
            btnThemBanAn.Text = "+ Thêm bàn ăn mới";
            btnThemBanAn.Click += btnThemBanAn_Click;
            // 
            // panelBan
            // 
            panelBan.AutoScroll = true;
            panelBan.AutoSize = true;
            panelBan.BackColor = Color.OldLace;
            panelBan.Dock = DockStyle.Fill;
            panelBan.Location = new Point(0, 73);
            panelBan.Name = "panelBan";
            panelBan.Size = new Size(378, 395);
            panelBan.TabIndex = 1;
            // 
            // MaCTHD
            // 
            MaCTHD.DataPropertyName = "MaCTHD";
            MaCTHD.HeaderText = "MaCTHD";
            MaCTHD.Name = "MaCTHD";
            MaCTHD.Visible = false;
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
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "MAHD";
            MaHD.Name = "MaHD";
            MaHD.Visible = false;
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "SL";
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 42;
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
            DonViTinh.Width = 51;
            // 
            // FormQuanLyBanAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(748, 468);
            Controls.Add(panel2);
            Controls.Add(panelCTBanAn);
            Name = "FormQuanLyBanAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyBanAN";
            Load += FormQuanLyBanAn_Load;
            panelCTBanAn.ResumeLayout(false);
            panelDsMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            panelCTMon.ResumeLayout(false);
            panelCTMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrSoluong).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelThanhToan.ResumeLayout(false);
            panelThanhToan.PerformLayout();
            panelGoiMon.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelCTBanAn;
        private Panel panel2;
        private FlowLayoutPanel panelBan;
        private Panel panelThanhToan;
        private Button btnThanhToan;
        private Panel panelGoiMon;
        private Button btnGoiMon;
        private Panel panel3;
        private Button buttonThongTin;
        private Label txtTenBan;
        private Panel panelDsMon;
        private Panel panelCTMon;
        private Button btnLuu;
        private Panel panel7;
        private Panel panel8;
        private Button btnThemMon;
        private Button button5;
        private DataGridView dgvMon;
        private NumericUpDown nbrSoluong;
        private Label label3;
        private Label label2;
        private Button btnXoa;
        private Label txtTongTien;
        private Label lbDVT;
        private Label lbGiaMon;
        private Label label5;
        private Label label4;
        private Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnThemBanAn;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMon;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private DataGridViewTextBoxColumn MaCTHD;
        private DataGridViewTextBoxColumn MaMA;
        private DataGridViewTextBoxColumn TenMA;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn DonViTinh;
    }
}