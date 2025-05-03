namespace QuanLyNhaHang
{
    partial class FormQuanLyNhanVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            panel2 = new Panel();
            btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            panelCT = new Panel();
            btClose = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            btnCapNhat = new Button();
            btnXoa = new Button();
            panelNewType = new Panel();
            txtChucVu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cbGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            label20 = new Label();
            txtDiaChi = new TextBox();
            label19 = new Label();
            txtTenNV = new TextBox();
            label18 = new Label();
            btnThem = new Button();
            panel3 = new Panel();
            dgvNhanVien = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelCT.SuspendLayout();
            panelNewType.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 97);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 65);
            panel1.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoRoundedCorners = true;
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(193, 15);
            txtTimKiem.Margin = new Padding(3, 5, 3, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(370, 35);
            txtTimKiem.TabIndex = 12;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(14, 21);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 11;
            label5.Text = "Nhập nội dung tìm kiếm:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Magenta;
            panel2.Controls.Add(btnThemKH);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 97);
            panel2.TabIndex = 3;
            // 
            // btnThemKH
            // 
            btnThemKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemKH.AutoRoundedCorners = true;
            btnThemKH.BackColor = Color.Magenta;
            btnThemKH.CustomizableEdges = customizableEdges3;
            btnThemKH.DefaultAutoSize = true;
            btnThemKH.DisabledState.BorderColor = Color.DarkGray;
            btnThemKH.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemKH.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemKH.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemKH.FillColor = Color.SeaGreen;
            btnThemKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemKH.ForeColor = Color.White;
            btnThemKH.Location = new Point(618, 28);
            btnThemKH.Margin = new Padding(3, 4, 3, 4);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThemKH.Size = new Size(238, 39);
            btnThemKH.TabIndex = 11;
            btnThemKH.Text = "+ Thêm nhân viên mới";
            btnThemKH.Click += btnThem1_Click;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(339, 97);
            label6.TabIndex = 10;
            label6.Text = "DANH SÁCH NHÂN VIÊN";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCT
            // 
            panelCT.BackColor = Color.Lavender;
            panelCT.Controls.Add(btClose);
            panelCT.Controls.Add(label1);
            panelCT.Controls.Add(btnCapNhat);
            panelCT.Controls.Add(btnXoa);
            panelCT.Controls.Add(panelNewType);
            panelCT.Controls.Add(btnThem);
            panelCT.Dock = DockStyle.Right;
            panelCT.Location = new Point(564, 162);
            panelCT.Margin = new Padding(3, 4, 3, 4);
            panelCT.Name = "panelCT";
            panelCT.Size = new Size(291, 462);
            panelCT.TabIndex = 4;
            panelCT.Visible = false;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.AutoRoundedCorners = true;
            btClose.CustomizableEdges = customizableEdges5;
            btClose.DisabledState.BorderColor = Color.DarkGray;
            btClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btClose.FillColor = Color.Tomato;
            btClose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(243, 11);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btClose.Size = new Size(38, 44);
            btClose.TabIndex = 34;
            btClose.Text = "X";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 33;
            label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapNhat.Location = new Point(103, 354);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(182, 45);
            btnCapNhat.TabIndex = 30;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Location = new Point(15, 354);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 45);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panelNewType
            // 
            panelNewType.Controls.Add(txtChucVu);
            panelNewType.Controls.Add(label4);
            panelNewType.Controls.Add(label3);
            panelNewType.Controls.Add(cbGioiTinh);
            panelNewType.Controls.Add(dtpNgaySinh);
            panelNewType.Controls.Add(label2);
            panelNewType.Controls.Add(txtSoDienThoai);
            panelNewType.Controls.Add(label20);
            panelNewType.Controls.Add(txtDiaChi);
            panelNewType.Controls.Add(label19);
            panelNewType.Controls.Add(txtTenNV);
            panelNewType.Controls.Add(label18);
            panelNewType.Location = new Point(7, 64);
            panelNewType.Margin = new Padding(3, 4, 3, 4);
            panelNewType.Name = "panelNewType";
            panelNewType.Size = new Size(278, 232);
            panelNewType.TabIndex = 27;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(114, 193);
            txtChucVu.Margin = new Padding(3, 4, 3, 4);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(159, 27);
            txtChucVu.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 199);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 20;
            label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 159);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 19;
            label3.Text = "Giới tính:";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(114, 155);
            cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(159, 28);
            cbGioiTinh.TabIndex = 18;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(114, 115);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(159, 27);
            dtpNgaySinh.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 120);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 16;
            label2.Text = "Ngày sinh:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(114, 76);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(159, 27);
            txtSoDienThoai.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 81);
            label20.Name = "label20";
            label20.Size = new Size(100, 20);
            label20.TabIndex = 14;
            label20.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(114, 40);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(159, 27);
            txtDiaChi.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(5, 45);
            label19.Name = "label19";
            label19.Size = new Size(58, 20);
            label19.TabIndex = 12;
            label19.Text = "Địa chỉ:";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(114, 4);
            txtTenNV.Margin = new Padding(3, 4, 3, 4);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(159, 27);
            txtTenNV.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 9);
            label18.Name = "label18";
            label18.Size = new Size(59, 20);
            label18.TabIndex = 10;
            label18.Text = "Tên KH:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.Location = new Point(15, 301);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(270, 45);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvNhanVien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 162);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 462);
            panel3.TabIndex = 5;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeColumns = false;
            dgvNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.ColumnHeadersHeight = 38;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, ChucVu });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(564, 462);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.Click += dgvNhanVien_Click;
            // 
            // MaNV
            // 
            MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 57;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên nhân viên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "GT";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 54;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 101;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SĐT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 63;
            // 
            // ChucVu
            // 
            ChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.Width = 88;
            // 
            // FormQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 624);
            Controls.Add(panel3);
            Controls.Add(panelCT);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormQuanLyNhanVien";
            Text = "FormQuanLyNhanVien";
            Load += FormQuanLyNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelCT.ResumeLayout(false);
            panelCT.PerformLayout();
            panelNewType.ResumeLayout(false);
            panelNewType.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelCT;
        private Button btnCapNhat;
        private Button btnXoa;
        private Panel panelNewType;
        private TextBox txtChucVu;
        private Label label4;
        private Label label3;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private Label label2;
        private TextBox txtSoDienThoai;
        private Label label20;
        private TextBox txtDiaChi;
        private Label label19;
        private TextBox txtTenNV;
        private Label label18;
        private Button btnThem;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn ChucVu;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}