namespace Baitaplon.Net.ChildForm
{
    partial class FmSach
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txbtk = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ID = new DataGridViewTextBoxColumn();
            tentheloai = new DataGridViewTextBoxColumn();
            tensach = new DataGridViewTextBoxColumn();
            tennxb = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            trangthai = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, tentheloai, tensach, tennxb, dongia, trangthai, soluong });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(811, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(88, 94);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // txbtk
            // 
            txbtk.Location = new Point(163, 94);
            txbtk.Name = "txbtk";
            txbtk.Size = new Size(151, 23);
            txbtk.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(320, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(411, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(501, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // tentheloai
            // 
            tentheloai.DataPropertyName = "tentheloai";
            tentheloai.HeaderText = "Tên thể loại";
            tentheloai.Name = "tentheloai";
            tentheloai.ReadOnly = true;
            // 
            // tensach
            // 
            tensach.DataPropertyName = "tensach";
            tensach.HeaderText = "Tên Sách";
            tensach.Name = "tensach";
            tensach.ReadOnly = true;
            // 
            // tennxb
            // 
            tennxb.DataPropertyName = "tennxb";
            tennxb.HeaderText = "Nhà xuất bản";
            tennxb.Name = "tennxb";
            tennxb.ReadOnly = true;
            // 
            // dongia
            // 
            dongia.DataPropertyName = "dongia";
            dongia.HeaderText = "Giá";
            dongia.Name = "dongia";
            dongia.ReadOnly = true;
            // 
            // trangthai
            // 
            trangthai.DataPropertyName = "trangthai";
            trangthai.HeaderText = "Trạng Thái";
            trangthai.Name = "trangthai";
            trangthai.ReadOnly = true;
            // 
            // soluong
            // 
            soluong.DataPropertyName = "soluong";
            soluong.HeaderText = "Số lượng";
            soluong.Name = "soluong";
            soluong.ReadOnly = true;
            // 
            // FmSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(811, 397);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txbtk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FmSach";
            Text = "FmSach";
            Load += FmSach_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txbtk;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tentheloai;
        private DataGridViewTextBoxColumn tensach;
        private DataGridViewTextBoxColumn tennxb;
        private DataGridViewTextBoxColumn dongia;
        private DataGridViewTextBoxColumn trangthai;
        private DataGridViewTextBoxColumn soluong;
    }
}