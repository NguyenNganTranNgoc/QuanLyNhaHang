namespace QuanLyNhaHang
{
    partial class FormQuanLyHoaDon
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            MaBan = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            GiamGia = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 97);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH HÓA ĐƠN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeColumns = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.ColumnHeadersHeight = 38;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHD, TenKhachHang, MaKH, MaNV, TenNhanVien, MaBan, NgayLap, TongTien, GiamGia, TrangThai });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.GridColor = SystemColors.Window;
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(914, 503);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.Click += dgvHoaDon_Click;
            // 
            // MaHD
            // 
            MaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hóa đơn";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.Width = 116;
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "KhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "MaKH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.Visible = false;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "MaNV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Visible = false;
            // 
            // TenNhanVien
            // 
            TenNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNhanVien.DataPropertyName = "NhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // MaBan
            // 
            MaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaBan.DataPropertyName = "MaBan";
            MaBan.HeaderText = "Mã bàn";
            MaBan.MinimumWidth = 6;
            MaBan.Name = "MaBan";
            MaBan.Width = 86;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // GiamGia
            // 
            GiamGia.DataPropertyName = "GiamGia";
            GiamGia.HeaderText = "Giảm giá";
            GiamGia.MinimumWidth = 6;
            GiamGia.Name = "GiamGia";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 97);
            panel1.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            txtTimKiem.Location = new Point(513, 33);
            txtTimKiem.Margin = new Padding(3, 5, 3, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(398, 31);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(336, 39);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập nội dung tìm kiếm:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHoaDon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 97);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 503);
            panel2.TabIndex = 4;
            // 
            // FormQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormQuanLyHoaDon";
            Text = "FormHoaDon";
            Load += FormQuanLyHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvHoaDon;
        private Panel panel1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn MaBan;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn GiamGia;
        private DataGridViewTextBoxColumn TrangThai;
    }
}