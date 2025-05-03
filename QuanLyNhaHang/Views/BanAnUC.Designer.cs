namespace QuanLyNhaHang
{
    partial class BanAnUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenBan = new Label();
            lbHD = new Label();
            lbTrangThai = new Label();
            lbLoaiBan = new Label();
            SuspendLayout();
            // 
            // txtTenBan
            // 
            txtTenBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTenBan.BackColor = Color.Transparent;
            txtTenBan.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenBan.ForeColor = Color.CornflowerBlue;
            txtTenBan.Location = new Point(0, 88);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(203, 37);
            txtTenBan.TabIndex = 0;
            txtTenBan.Text = "BÀN 1";
            txtTenBan.TextAlign = ContentAlignment.MiddleCenter;
            txtTenBan.Click += txtTenBan_Click;
            txtTenBan.MouseLeave += txtTenBan_MouseLeave;
            txtTenBan.MouseHover += txtTenBan_MouseHover;
            // 
            // lbHD
            // 
            lbHD.BackColor = Color.Transparent;
            lbHD.ForeColor = Color.CornflowerBlue;
            lbHD.Location = new Point(29, 126);
            lbHD.Name = "lbHD";
            lbHD.Size = new Size(145, 19);
            lbHD.TabIndex = 1;
            lbHD.Text = "HĐ: 20.000.000 VNĐ";
            lbHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTrangThai
            // 
            lbTrangThai.BackColor = Color.Transparent;
            lbTrangThai.Dock = DockStyle.Top;
            lbTrangThai.Location = new Point(0, 0);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(203, 27);
            lbTrangThai.TabIndex = 2;
            lbTrangThai.Text = "Trạng thái: Trống";
            lbTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            lbTrangThai.Visible = false;
            lbTrangThai.Click += lbTrangThai_Click;
            // 
            // lbLoaiBan
            // 
            lbLoaiBan.BackColor = Color.Transparent;
            lbLoaiBan.ForeColor = Color.CornflowerBlue;
            lbLoaiBan.Location = new Point(29, 68);
            lbLoaiBan.Name = "lbLoaiBan";
            lbLoaiBan.Size = new Size(145, 20);
            lbLoaiBan.TabIndex = 4;
            lbLoaiBan.Text = "Loại bàn: VIP";
            lbLoaiBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BanAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.table_01;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lbLoaiBan);
            Controls.Add(lbTrangThai);
            Controls.Add(lbHD);
            Controls.Add(txtTenBan);
            DoubleBuffered = true;
            Name = "BanAn";
            Size = new Size(203, 220);
            Load += BanAn_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label txtTenBan;
        private Label lbHD;
        private Label lbTrangThai;
        private Label lbLoaiBan;
    }
}
