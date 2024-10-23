namespace Baitaplon.Net.ChildForm
{
    partial class FmThue
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
            label1 = new Label();
            label2 = new Label();
            txbtk = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dtgvThue = new DataGridView();
            conlai = new DataGridViewTextBoxColumn();
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
            tentheloai = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvThue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thuê sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(113, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // txbtk
            // 
            txbtk.Location = new Point(191, 81);
            txbtk.Name = "txbtk";
            txbtk.Size = new Size(213, 23);
            txbtk.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(424, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(517, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Thuê mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtgvThue
            // 
            dtgvThue.BackgroundColor = SystemColors.Control;
            dtgvThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThue.Columns.AddRange(new DataGridViewColumn[] { conlai, tensach, tenkh, sdt, email, diachi, soluong, dongia, datcoc, ngaythue, ngaytra, tentheloai, ID });
            dtgvThue.Dock = DockStyle.Bottom;
            dtgvThue.Location = new Point(0, 110);
            dtgvThue.Name = "dtgvThue";
            dtgvThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvThue.Size = new Size(811, 287);
            dtgvThue.TabIndex = 5;
            // 
            // conlai
            // 
            conlai.DataPropertyName = "conlai";
            conlai.HeaderText = "conlai";
            conlai.Name = "conlai";
            conlai.Visible = false;
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
            diachi.HeaderText = "Địa chỉ";
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
            dongia.HeaderText = "Giá";
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
            // tentheloai
            // 
            tentheloai.DataPropertyName = "tentheloai";
            tentheloai.HeaderText = "Tên Thể Loại";
            tentheloai.Name = "tentheloai";
            tentheloai.Visible = false;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // FmThue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(811, 397);
            Controls.Add(dtgvThue);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txbtk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmThue";
            Text = "FmThue";
            Load += FmThue_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbtk;
        private Button button1;
        private Button button2;
        private DataGridView dtgvThue;
        private DataGridViewTextBoxColumn conlai;
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
        private DataGridViewTextBoxColumn tentheloai;
        private DataGridViewTextBoxColumn ID;
    }
}