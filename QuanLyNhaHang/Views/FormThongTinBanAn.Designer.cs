namespace QuanLyNhaHang
{
    partial class FormThongTinBanAn
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
            btnXoa = new Button();
            btnLuu = new Button();
            panelChooseType = new Panel();
            txtTenBan = new Label();
            panelNewType = new Panel();
            cbbLoaiBan = new ComboBox();
            txtTrangThai = new TextBox();
            label20 = new Label();
            label19 = new Label();
            txtSoBan = new TextBox();
            label18 = new Label();
            panelChooseType.SuspendLayout();
            panelNewType.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(13, 129);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 23);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(170, 129);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(64, 23);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panelChooseType
            // 
            panelChooseType.Controls.Add(txtTenBan);
            panelChooseType.Dock = DockStyle.Top;
            panelChooseType.Location = new Point(0, 0);
            panelChooseType.Name = "panelChooseType";
            panelChooseType.Size = new Size(246, 29);
            panelChooseType.TabIndex = 23;
            // 
            // txtTenBan
            // 
            txtTenBan.AutoSize = true;
            txtTenBan.Location = new Point(87, 7);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(84, 15);
            txtTenBan.TabIndex = 0;
            txtTenBan.Text = "Thông tin bàn:";
            // 
            // panelNewType
            // 
            panelNewType.Controls.Add(cbbLoaiBan);
            panelNewType.Controls.Add(txtTrangThai);
            panelNewType.Controls.Add(label20);
            panelNewType.Controls.Add(label19);
            panelNewType.Controls.Add(txtSoBan);
            panelNewType.Controls.Add(label18);
            panelNewType.Dock = DockStyle.Top;
            panelNewType.Location = new Point(0, 29);
            panelNewType.Name = "panelNewType";
            panelNewType.Size = new Size(246, 88);
            panelNewType.TabIndex = 24;
            // 
            // cbbLoaiBan
            // 
            cbbLoaiBan.FormattingEnabled = true;
            cbbLoaiBan.Items.AddRange(new object[] { "Thường", "VIP" });
            cbbLoaiBan.Location = new Point(109, 30);
            cbbLoaiBan.Name = "cbbLoaiBan";
            cbbLoaiBan.Size = new Size(125, 23);
            cbbLoaiBan.TabIndex = 21;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Enabled = false;
            txtTrangThai.Location = new Point(109, 57);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 23);
            txtTrangThai.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 61);
            label20.Name = "label20";
            label20.Size = new Size(62, 15);
            label20.TabIndex = 14;
            label20.Text = "Trạng thái:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(13, 34);
            label19.Name = "label19";
            label19.Size = new Size(55, 15);
            label19.TabIndex = 12;
            label19.Text = "Loại bàn:";
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(109, 3);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(125, 23);
            txtSoBan.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 7);
            label18.Name = "label18";
            label18.Size = new Size(46, 15);
            label18.TabIndex = 10;
            label18.Text = "Số bàn:";
            // 
            // FormThongTinBanAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 160);
            Controls.Add(panelNewType);
            Controls.Add(panelChooseType);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Name = "FormThongTinBanAn";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormThongTinBanAn";
            Load += FormThongTinBanAn_Load;
            panelChooseType.ResumeLayout(false);
            panelChooseType.PerformLayout();
            panelNewType.ResumeLayout(false);
            panelNewType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXoa;
        private Button btnLuu;
        private Panel panelChooseType;
        private Label txtTenBan;
        private Panel panelNewType;
        private ComboBox cbbLoaiBan;
        private TextBox txtTrangThai;
        private Label label20;
        private Label label19;
        private TextBox txtSoBan;
        private Label label18;
    }
}