namespace Baitaplon.Net.ChildForm
{
    partial class FmDoanhThu
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
            button1 = new Button();
            label1 = new Label();
            dtgvDoanhTHu = new DataGridView();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            DoanhThu = new DataGridViewTextBoxColumn();
            NgayThue = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            mtbNgayTra = new MaskedTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvDoanhTHu).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(398, 91);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(93, 26);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản lý doanh thu";
            // 
            // dtgvDoanhTHu
            // 
            dtgvDoanhTHu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDoanhTHu.BackgroundColor = SystemColors.ControlLightLight;
            dtgvDoanhTHu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDoanhTHu.Columns.AddRange(new DataGridViewColumn[] { TenSach, SoLuong, TenKhachHang, DoanhThu, NgayThue, NgayTra, ID });
            dtgvDoanhTHu.Location = new Point(0, 120);
            dtgvDoanhTHu.Name = "dtgvDoanhTHu";
            dtgvDoanhTHu.Size = new Size(811, 277);
            dtgvDoanhTHu.TabIndex = 2;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.Name = "TenSach";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.Name = "TenKhachHang";
            // 
            // DoanhThu
            // 
            DoanhThu.DataPropertyName = "DoanhThu";
            DoanhThu.HeaderText = "Doanh thu";
            DoanhThu.Name = "DoanhThu";
            // 
            // NgayThue
            // 
            NgayThue.DataPropertyName = "NgayThue";
            NgayThue.HeaderText = "Ngày Thuê";
            NgayThue.Name = "NgayThue";
            // 
            // NgayTra
            // 
            NgayTra.DataPropertyName = "NgayTra";
            NgayTra.HeaderText = "Ngày Trả";
            NgayTra.Name = "NgayTra";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // mtbNgayTra
            // 
            mtbNgayTra.Location = new Point(143, 92);
            mtbNgayTra.Mask = "00/00/0000";
            mtbNgayTra.Name = "mtbNgayTra";
            mtbNgayTra.Size = new Size(249, 23);
            mtbNgayTra.TabIndex = 23;
            mtbNgayTra.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 24;
            label2.Text = "Ngày trả sách";
            // 
            // FmDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(811, 397);
            Controls.Add(label2);
            Controls.Add(mtbNgayTra);
            Controls.Add(dtgvDoanhTHu);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FmDoanhThu";
            Text = "FmDoanhThu";
            Load += FmDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDoanhTHu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dtgvDoanhTHu;
        private MaskedTextBox mtbNgayTra;
        private Label label2;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn DoanhThu;
        private DataGridViewTextBoxColumn NgayThue;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn ID;
    }
}