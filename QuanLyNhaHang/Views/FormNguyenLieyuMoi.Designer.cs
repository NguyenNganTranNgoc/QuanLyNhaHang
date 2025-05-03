namespace QuanLyNhaHang
{
    partial class FormNguyenLieyuMoi
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
            panel1 = new Panel();
            btnThem = new Button();
            txtDVT = new TextBox();
            label10 = new Label();
            txtTenNguyenLieu = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtDVT);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtTenNguyenLieu);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 98);
            panel1.TabIndex = 28;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.Location = new Point(4, 59);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(237, 34);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(100, 31);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(140, 23);
            txtDVT.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 34);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 12;
            label10.Text = "Đơn vị tính:";
            // 
            // txtTenNguyenLieu
            // 
            txtTenNguyenLieu.Location = new Point(100, 3);
            txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            txtTenNguyenLieu.Size = new Size(140, 23);
            txtTenNguyenLieu.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 7);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 10;
            label11.Text = "Tên NL:";
            // 
            // FormNguyenLieyuMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 98);
            Controls.Add(panel1);
            Name = "FormNguyenLieyuMoi";
            Text = "FormNguyenLieyuMoi";
            Load += FormNguyenLieyuMoi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtDVT;
        private Label label10;
        private TextBox txtTenNguyenLieu;
        private Label label11;
        private Button btnThem;
    }
}