namespace QuanLyNhaHang
{
    partial class FormQuanLyKhachHang
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            panelCT = new Panel();
            btClose = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            btnCapNhat = new Button();
            btnXoa = new Button();
            panelNewType = new Panel();
            txtSoDienThoai = new TextBox();
            label20 = new Label();
            txtDiaChi = new TextBox();
            label19 = new Label();
            txtTenKH = new TextBox();
            label18 = new Label();
            btnThem = new Button();
            panel3 = new Panel();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panelCT.SuspendLayout();
            panelNewType.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Controls.Add(btnThemKH);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 73);
            panel1.TabIndex = 0;
            // 
            // btnThemKH
            // 
            btnThemKH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemKH.AutoRoundedCorners = true;
            btnThemKH.BackColor = Color.Magenta;
            btnThemKH.CustomizableEdges = customizableEdges13;
            btnThemKH.DefaultAutoSize = true;
            btnThemKH.DisabledState.BorderColor = Color.DarkGray;
            btnThemKH.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemKH.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemKH.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemKH.FillColor = Color.SeaGreen;
            btnThemKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemKH.ForeColor = Color.White;
            btnThemKH.Location = new Point(566, 20);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnThemKH.Size = new Size(176, 33);
            btnThemKH.TabIndex = 3;
            btnThemKH.Text = "+ Thêm khách hàng";
            btnThemKH.Click += btnThem1_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(297, 73);
            label4.TabIndex = 7;
            label4.Text = "DANH SÁCH KHÁCH HÀNG";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.AutoRoundedCorners = true;
            txtTimKiem.CustomizableEdges = customizableEdges15;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(165, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtTimKiem.Size = new Size(300, 26);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(7, 14);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 8;
            label3.Text = "Nhập nội dung tìm kiếm:";
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
            panelCT.Location = new Point(493, 73);
            panelCT.Name = "panelCT";
            panelCT.Size = new Size(255, 395);
            panelCT.TabIndex = 1;
            panelCT.Visible = false;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.AutoRoundedCorners = true;
            btClose.CustomizableEdges = customizableEdges17;
            btClose.DisabledState.BorderColor = Color.DarkGray;
            btClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btClose.FillColor = Color.Tomato;
            btClose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(216, 7);
            btClose.Name = "btClose";
            btClose.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btClose.Size = new Size(33, 33);
            btClose.TabIndex = 32;
            btClose.Text = "X";
            btClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 31;
            label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapNhat.Location = new Point(90, 354);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(159, 34);
            btnCapNhat.TabIndex = 30;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Location = new Point(13, 354);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 34);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panelNewType
            // 
            panelNewType.Controls.Add(txtSoDienThoai);
            panelNewType.Controls.Add(label20);
            panelNewType.Controls.Add(txtDiaChi);
            panelNewType.Controls.Add(label19);
            panelNewType.Controls.Add(txtTenKH);
            panelNewType.Controls.Add(label18);
            panelNewType.Location = new Point(6, 49);
            panelNewType.Name = "panelNewType";
            panelNewType.Size = new Size(243, 86);
            panelNewType.TabIndex = 27;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(100, 57);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(140, 23);
            txtSoDienThoai.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 61);
            label20.Name = "label20";
            label20.Size = new Size(79, 15);
            label20.TabIndex = 14;
            label20.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(100, 30);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(140, 23);
            txtDiaChi.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 34);
            label19.Name = "label19";
            label19.Size = new Size(46, 15);
            label19.TabIndex = 12;
            label19.Text = "Địa chỉ:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(100, 3);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(140, 23);
            txtTenKH.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 7);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 10;
            label18.Text = "Tên KH:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.Location = new Point(13, 314);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(236, 34);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvKhachHang);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 395);
            panel3.TabIndex = 2;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AllowUserToResizeColumns = false;
            dgvKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 255, 164);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 128, 64);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 128, 64);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, HoTen, SDT, DiaChi });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 188, 155);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle11;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.GridColor = SystemColors.Window;
            dgvKhachHang.Location = new Point(0, 49);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 188, 155);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 188, 155);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(493, 346);
            dgvKhachHang.TabIndex = 1;
            dgvKhachHang.Click += dgvKhachHang_Click;
            // 
            // MaKH
            // 
            MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "Mã";
            MaKH.Name = "MaKH";
            MaKH.Width = 47;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.Name = "HoTen";
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 49);
            panel2.TabIndex = 0;
            // 
            // FormQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 468);
            Controls.Add(panel3);
            Controls.Add(panelCT);
            Controls.Add(panel1);
            Name = "FormQuanLyKhachHang";
            Text = "FormQuanLyKhachHang";
            Load += FormQuanLyKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCT.ResumeLayout(false);
            panelCT.PerformLayout();
            panelNewType.ResumeLayout(false);
            panelNewType.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelCT;
        private Panel panel3;
        private DataGridView dgvKhachHang;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private Panel panelNewType;
        private TextBox txtSoDienThoai;
        private Label label20;
        private TextBox txtDiaChi;
        private Label label19;
        private TextBox txtTenKH;
        private Label label18;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btClose;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
    }
}