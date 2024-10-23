namespace Baitaplon.Net
{
    partial class FmTraSach
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
            dtgvtra = new DataGridView();
            btnthanhtoan = new DataGridViewButtonColumn();
            btnTraSach = new DataGridViewButtonColumn();
            tentheloai = new DataGridViewTextBoxColumn();
            tensach = new DataGridViewTextBoxColumn();
            tenkh = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            datcoc = new DataGridViewTextBoxColumn();
            ngaythue = new DataGridViewTextBoxColumn();
            ngaytra = new DataGridViewTextBoxColumn();
            conlai = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            txbtk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvtra).BeginInit();
            SuspendLayout();
            // 
            // dtgvtra
            // 
            dtgvtra.BackgroundColor = SystemColors.Control;
            dtgvtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvtra.Columns.AddRange(new DataGridViewColumn[] { btnthanhtoan, btnTraSach, tentheloai, tensach, tenkh, sdt, email, diachi, soluong, dongia, datcoc, ngaythue, ngaytra, conlai, ID });
            dtgvtra.Dock = DockStyle.Bottom;
            dtgvtra.Location = new Point(0, 126);
            dtgvtra.Name = "dtgvtra";
            dtgvtra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvtra.Size = new Size(811, 271);
            dtgvtra.TabIndex = 11;
            dtgvtra.CellClick += dtgvtra_CellClick;
            // 
            // btnthanhtoan
            // 
            btnthanhtoan.HeaderText = "Thanh toán";
            btnthanhtoan.Name = "btnthanhtoan";
            btnthanhtoan.Resizable = DataGridViewTriState.True;
            btnthanhtoan.SortMode = DataGridViewColumnSortMode.Automatic;
            btnthanhtoan.Text = "Thanh Toán";
            btnthanhtoan.UseColumnTextForButtonValue = true;
            // 
            // btnTraSach
            // 
            btnTraSach.HeaderText = "Trả sách";
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Resizable = DataGridViewTriState.True;
            btnTraSach.SortMode = DataGridViewColumnSortMode.Automatic;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseColumnTextForButtonValue = true;
            // 
            // tentheloai
            // 
            tentheloai.DataPropertyName = "tentheloai";
            tentheloai.HeaderText = "tentheloai";
            tentheloai.Name = "tentheloai";
            tentheloai.Visible = false;
            // 
            // tensach
            // 
            tensach.DataPropertyName = "tensach";
            tensach.HeaderText = "Tên sách";
            tensach.Name = "tensach";
            // 
            // tenkh
            // 
            tenkh.DataPropertyName = "tenkh";
            tenkh.HeaderText = "Tên khách hàng";
            tenkh.Name = "tenkh";
            // 
            // sdt
            // 
            sdt.DataPropertyName = "sdt";
            sdt.HeaderText = "SDT";
            sdt.Name = "sdt";
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa Chỉ";
            diachi.Name = "diachi";
            // 
            // soluong
            // 
            soluong.DataPropertyName = "soluong";
            soluong.HeaderText = "Số lượng";
            soluong.Name = "soluong";
            // 
            // dongia
            // 
            dongia.DataPropertyName = "dongia";
            dongia.HeaderText = "Đơn giá";
            dongia.Name = "dongia";
            // 
            // datcoc
            // 
            datcoc.DataPropertyName = "datcoc";
            datcoc.HeaderText = "Đặt cọc";
            datcoc.Name = "datcoc";
            // 
            // ngaythue
            // 
            ngaythue.DataPropertyName = "ngaythue";
            ngaythue.HeaderText = "Ngày thuê";
            ngaythue.Name = "ngaythue";
            // 
            // ngaytra
            // 
            ngaytra.DataPropertyName = "ngaytra";
            ngaytra.HeaderText = "Ngày Trả";
            ngaytra.Name = "ngaytra";
            // 
            // conlai
            // 
            conlai.DataPropertyName = "conlai";
            conlai.HeaderText = "Số tiền còn lại";
            conlai.Name = "conlai";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(534, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Thuê mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(441, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txbtk
            // 
            txbtk.Location = new Point(208, 81);
            txbtk.Name = "txbtk";
            txbtk.Size = new Size(213, 23);
            txbtk.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(130, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 6;
            label1.Text = "Quản lý trả sách";
            // 
            // FmTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(811, 397);
            Controls.Add(dtgvtra);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txbtk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmTraSach";
            Text = "FmTraSach";
            Load += FmTraSach_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgvtra;
        private Button button2;
        private Button button1;
        private TextBox txbtk;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnthanhtoan;
        private DataGridViewButtonColumn btnTraSach;
        private DataGridViewTextBoxColumn tentheloai;
        private DataGridViewTextBoxColumn tensach;
        private DataGridViewTextBoxColumn tenkh;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn dongia;
        private DataGridViewTextBoxColumn datcoc;
        private DataGridViewTextBoxColumn ngaythue;
        private DataGridViewTextBoxColumn ngaytra;
        private DataGridViewTextBoxColumn conlai;
        private DataGridViewTextBoxColumn ID;
    }
}