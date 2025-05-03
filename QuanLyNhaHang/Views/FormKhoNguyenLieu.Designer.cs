namespace QuanLyNhaHang
{
    partial class FormKhoNguyenLieu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnThemKM = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            dgvKho = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.Controls.Add(btnThemKM);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 97);
            panel1.TabIndex = 4;
            // 
            // btnThemKM
            // 
            btnThemKM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemKM.AutoRoundedCorners = true;
            btnThemKM.BackColor = Color.Magenta;
            btnThemKM.CustomizableEdges = customizableEdges1;
            btnThemKM.DefaultAutoSize = true;
            btnThemKM.DisabledState.BorderColor = Color.DarkGray;
            btnThemKM.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemKM.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemKM.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemKM.FillColor = Color.SeaGreen;
            btnThemKM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemKM.ForeColor = Color.White;
            btnThemKM.Location = new Point(688, 32);
            btnThemKM.Margin = new Padding(3, 4, 3, 4);
            btnThemKM.Name = "btnThemKM";
            btnThemKM.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThemKM.Size = new Size(214, 39);
            btnThemKM.TabIndex = 3;
            btnThemKM.Text = "+ Thêm nguyên liệu";
            btnThemKM.Click += btnThemKM_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(339, 97);
            label4.TabIndex = 7;
            label4.Text = "KHO NGUYÊN LIỆU";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKho.ColumnHeadersHeight = 25;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKho.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKho.Dock = DockStyle.Fill;
            dgvKho.GridColor = Color.FromArgb(231, 229, 255);
            dgvKho.Location = new Point(0, 97);
            dgvKho.Margin = new Padding(3, 4, 3, 4);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvKho.RowHeadersVisible = false;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.RowTemplate.Height = 25;
            dgvKho.Size = new Size(914, 503);
            dgvKho.TabIndex = 5;
            dgvKho.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKho.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvKho.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvKho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvKho.ThemeStyle.BackColor = Color.White;
            dgvKho.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvKho.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvKho.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKho.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvKho.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvKho.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvKho.ThemeStyle.HeaderStyle.Height = 25;
            dgvKho.ThemeStyle.ReadOnly = false;
            dgvKho.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 128, 128);
            dgvKho.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKho.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvKho.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvKho.ThemeStyle.RowsStyle.Height = 25;
            dgvKho.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKho.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FormKhoNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvKho);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormKhoNguyenLieu";
            Text = "FormKhoNguyenLieu";
            Load += FormKhoNguyenLieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKho;
        private Guna.UI2.WinForms.Guna2Button btnThemKM;
    }
}