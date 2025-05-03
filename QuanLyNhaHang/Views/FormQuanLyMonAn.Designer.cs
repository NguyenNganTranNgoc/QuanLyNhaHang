namespace QuanLyNhaHang
{
    partial class FormQuanLyMonAn
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panelCT = new Panel();
            btnDoiAnh = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panelNewType = new Panel();
            label2 = new Label();
            cbbTinhTrang = new ComboBox();
            txtGiaMon = new TextBox();
            label20 = new Label();
            txtDVT = new TextBox();
            label19 = new Label();
            txtTenMon = new TextBox();
            label18 = new Label();
            panelOldType = new Panel();
            label17 = new Label();
            cbbDanhMuc = new ComboBox();
            pbAvatar = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            dgvMonAn = new DataGridView();
            ImageMA = new DataGridViewImageColumn();
            MaMA = new DataGridViewTextBoxColumn();
            TenMA = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            DanhMuc = new DataGridViewTextBoxColumn();
            TrangThaiMon = new DataGridViewTextBoxColumn();
            AnhMA = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            btClose = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panelCT.SuspendLayout();
            panelNewType.SuspendLayout();
            panelOldType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Controls.Add(btnThemMon);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 73);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(10, 17);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 5;
            label3.Text = "Nhập nội dung tìm kiếm:";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(259, 73);
            label4.TabIndex = 4;
            label4.Text = "DANH SÁCH MÓN ĂN";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCT
            // 
            panelCT.BackColor = Color.Lavender;
            panelCT.Controls.Add(btClose);
            panelCT.Controls.Add(label5);
            panelCT.Controls.Add(btnDoiAnh);
            panelCT.Controls.Add(btnCapNhat);
            panelCT.Controls.Add(btnXoa);
            panelCT.Controls.Add(btnThem);
            panelCT.Controls.Add(panelNewType);
            panelCT.Controls.Add(panelOldType);
            panelCT.Controls.Add(pbAvatar);
            panelCT.Controls.Add(label1);
            panelCT.Dock = DockStyle.Right;
            panelCT.Location = new Point(478, 73);
            panelCT.Name = "panelCT";
            panelCT.Size = new Size(270, 488);
            panelCT.TabIndex = 1;
            panelCT.Visible = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(179, 158);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 23);
            btnDoiAnh.TabIndex = 27;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCapNhat.Location = new Point(95, 447);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(159, 34);
            btnCapNhat.TabIndex = 26;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Location = new Point(18, 447);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 34);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThem.Location = new Point(18, 408);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(236, 34);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panelNewType
            // 
            panelNewType.Controls.Add(label2);
            panelNewType.Controls.Add(cbbTinhTrang);
            panelNewType.Controls.Add(txtGiaMon);
            panelNewType.Controls.Add(label20);
            panelNewType.Controls.Add(txtDVT);
            panelNewType.Controls.Add(label19);
            panelNewType.Controls.Add(txtTenMon);
            panelNewType.Controls.Add(label18);
            panelNewType.Dock = DockStyle.Top;
            panelNewType.Location = new Point(0, 218);
            panelNewType.Name = "panelNewType";
            panelNewType.Size = new Size(270, 112);
            panelNewType.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "Tình trạng:";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Còn hàng", "Hết hàng" });
            cbbTinhTrang.Location = new Point(114, 86);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(140, 23);
            cbbTinhTrang.TabIndex = 16;
            // 
            // txtGiaMon
            // 
            txtGiaMon.Location = new Point(114, 57);
            txtGiaMon.Name = "txtGiaMon";
            txtGiaMon.Size = new Size(140, 23);
            txtGiaMon.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 61);
            label20.Name = "label20";
            label20.Size = new Size(55, 15);
            label20.TabIndex = 14;
            label20.Text = "Giá món:";
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(114, 30);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(140, 23);
            txtDVT.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 34);
            label19.Name = "label19";
            label19.Size = new Size(68, 15);
            label19.TabIndex = 12;
            label19.Text = "Đơn vị tính:";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(114, 3);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(140, 23);
            txtTenMon.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 7);
            label18.Name = "label18";
            label18.Size = new Size(72, 15);
            label18.TabIndex = 10;
            label18.Text = "Tên món ăn:";
            // 
            // panelOldType
            // 
            panelOldType.Controls.Add(label17);
            panelOldType.Controls.Add(cbbDanhMuc);
            panelOldType.Dock = DockStyle.Top;
            panelOldType.Location = new Point(0, 187);
            panelOldType.Name = "panelOldType";
            panelOldType.Size = new Size(270, 31);
            panelOldType.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 10);
            label17.Name = "label17";
            label17.Size = new Size(65, 15);
            label17.TabIndex = 3;
            label17.Text = "Danh mục:";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(114, 7);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(140, 23);
            cbbDanhMuc.TabIndex = 0;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = SystemColors.ActiveCaption;
            pbAvatar.BackgroundImage = Properties.Resources.photo;
            pbAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            pbAvatar.Dock = DockStyle.Top;
            pbAvatar.Location = new Point(0, 44);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(270, 143);
            pbAvatar.TabIndex = 3;
            pbAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 44);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvMonAn);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 488);
            panel3.TabIndex = 2;
            // 
            // dgvMonAn
            // 
            dgvMonAn.AllowUserToAddRows = false;
            dgvMonAn.AllowUserToDeleteRows = false;
            dgvMonAn.AllowUserToResizeColumns = false;
            dgvMonAn.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dgvMonAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMonAn.BorderStyle = BorderStyle.None;
            dgvMonAn.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMonAn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvMonAn.ColumnHeadersHeight = 38;
            dgvMonAn.Columns.AddRange(new DataGridViewColumn[] { ImageMA, MaMA, TenMA, DonViTinh, Gia, DanhMuc, TrangThaiMon, AnhMA });
            dgvMonAn.Dock = DockStyle.Fill;
            dgvMonAn.EnableHeadersVisualStyles = false;
            dgvMonAn.Location = new Point(0, 44);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvMonAn.RowHeadersVisible = false;
            dgvMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonAn.Size = new Size(478, 444);
            dgvMonAn.TabIndex = 1;
            dgvMonAn.Click += dgvMonAn_Click;
            // 
            // ImageMA
            // 
            ImageMA.DataPropertyName = "ImageMA";
            ImageMA.HeaderText = "Ảnh Minh Họa";
            ImageMA.Image = Properties.Resources.photo;
            ImageMA.Name = "ImageMA";
            ImageMA.Visible = false;
            // 
            // MaMA
            // 
            MaMA.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaMA.DataPropertyName = "MaMA";
            MaMA.HeaderText = "Mã";
            MaMA.Name = "MaMA";
            MaMA.Width = 47;
            // 
            // TenMA
            // 
            TenMA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMA.DataPropertyName = "TenMA";
            TenMA.HeaderText = "Tên món ăn";
            TenMA.Name = "TenMA";
            // 
            // DonViTinh
            // 
            DonViTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "ĐVT";
            DonViTinh.Name = "DonViTinh";
            DonViTinh.Width = 51;
            // 
            // Gia
            // 
            Gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá bán";
            Gia.Name = "Gia";
            Gia.Width = 65;
            // 
            // DanhMuc
            // 
            DanhMuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DanhMuc.DataPropertyName = "DanhMuc";
            DanhMuc.HeaderText = "Danh mục";
            DanhMuc.Name = "DanhMuc";
            DanhMuc.Width = 78;
            // 
            // TrangThaiMon
            // 
            TrangThaiMon.DataPropertyName = "TrangThaiMon";
            TrangThaiMon.HeaderText = "Trạng Thái";
            TrangThaiMon.Name = "TrangThaiMon";
            // 
            // AnhMA
            // 
            AnhMA.DataPropertyName = "AnhMA";
            AnhMA.HeaderText = "AnhMA";
            AnhMA.Name = "AnhMA";
            AnhMA.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Linen;
            panel4.Controls.Add(txtTimKiem);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(478, 44);
            panel4.TabIndex = 0;
            // 
            // btnThemMon
            // 
            btnThemMon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMon.AutoRoundedCorners = true;
            btnThemMon.BackColor = Color.Magenta;
            btnThemMon.CustomizableEdges = customizableEdges15;
            btnThemMon.DefaultAutoSize = true;
            btnThemMon.DisabledState.BorderColor = Color.DarkGray;
            btnThemMon.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemMon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemMon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemMon.FillColor = Color.SeaGreen;
            btnThemMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemMon.ForeColor = Color.White;
            btnThemMon.Location = new Point(592, 21);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnThemMon.Size = new Size(147, 33);
            btnThemMon.TabIndex = 5;
            btnThemMon.Text = "+ Thêm món ăn";
            btnThemMon.Click += btnThemMon_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(6, 12);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 7;
            label5.Text = "THÔNG TIN MÓN ĂN";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.AutoRoundedCorners = true;
            txtTimKiem.CustomizableEdges = customizableEdges17;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(156, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtTimKiem.Size = new Size(300, 26);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.AutoRoundedCorners = true;
            btClose.CustomizableEdges = customizableEdges13;
            btClose.DisabledState.BorderColor = Color.DarkGray;
            btClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btClose.FillColor = Color.Tomato;
            btClose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(225, 6);
            btClose.Name = "btClose";
            btClose.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btClose.Size = new Size(33, 33);
            btClose.TabIndex = 33;
            btClose.Text = "X";
            btClose.Click += btnClose_Click;
            // 
            // FormQuanLyMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 561);
            Controls.Add(panel3);
            Controls.Add(panelCT);
            Controls.Add(panel1);
            Name = "FormQuanLyMonAn";
            Text = "FormQuanLyMonAn";
            Load += FormQuanLyMonAn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCT.ResumeLayout(false);
            panelCT.PerformLayout();
            panelNewType.ResumeLayout(false);
            panelNewType.PerformLayout();
            panelOldType.ResumeLayout(false);
            panelOldType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelCT;
        private Panel panel3;
        private DataGridView dgvMonAn;
        private Panel panel4;
        private Panel panelNewType;
        private Label label2;
        private ComboBox cbbTinhTrang;
        private TextBox txtGiaMon;
        private Label label20;
        private TextBox txtDVT;
        private Label label19;
        private TextBox txtTenMon;
        private Label label18;
        private Panel panelOldType;
        private Label label17;
        private ComboBox cbbDanhMuc;
        private PictureBox pbAvatar;
        private Label label3;
        private Label label4;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private Button btnDoiAnh;
        private Label label1;
        private Button btnClose;
        private DataGridViewImageColumn ImageMA;
        private DataGridViewTextBoxColumn MaMA;
        private DataGridViewTextBoxColumn TenMA;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn DanhMuc;
        private DataGridViewTextBoxColumn TrangThaiMon;
        private DataGridViewTextBoxColumn AnhMA;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btClose;
    }
}