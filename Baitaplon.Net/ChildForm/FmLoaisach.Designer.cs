namespace Baitaplon.Net.ChildForm
{
    partial class FmLoaisach
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
            txbS = new TextBox();
            label3 = new Label();
            txbG = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dtgvLoaisach = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            tentheloai = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvLoaisach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản lý danh mục sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(51, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // txbS
            // 
            txbS.Location = new Point(134, 41);
            txbS.Name = "txbS";
            txbS.Size = new Size(144, 23);
            txbS.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(51, 72);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 3;
            label3.Text = "Giá";
            // 
            // txbG
            // 
            txbG.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txbG.Location = new Point(134, 72);
            txbG.Name = "txbG";
            txbG.Size = new Size(100, 23);
            txbG.TabIndex = 4;
            txbG.Tag = "";
            txbG.KeyPress += txbG_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.InfoText;
            btnThem.Location = new Point(307, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 54);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSua.ForeColor = SystemColors.InfoText;
            btnSua.Location = new Point(415, 41);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 54);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXoa.ForeColor = SystemColors.InfoText;
            btnXoa.Location = new Point(529, 41);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 54);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgvLoaisach
            // 
            dtgvLoaisach.AllowUserToAddRows = false;
            dtgvLoaisach.AllowUserToDeleteRows = false;
            dtgvLoaisach.BackgroundColor = SystemColors.Control;
            dtgvLoaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLoaisach.Columns.AddRange(new DataGridViewColumn[] { ID, tentheloai, dongia });
            dtgvLoaisach.Dock = DockStyle.Bottom;
            dtgvLoaisach.Location = new Point(0, 121);
            dtgvLoaisach.MultiSelect = false;
            dtgvLoaisach.Name = "dtgvLoaisach";
            dtgvLoaisach.ReadOnly = true;
            dtgvLoaisach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLoaisach.Size = new Size(701, 261);
            dtgvLoaisach.TabIndex = 8;
            dtgvLoaisach.CellClick += dtgvLoaisach_CellClick;
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
            // dongia
            // 
            dongia.DataPropertyName = "dongia";
            dongia.HeaderText = "Giá";
            dongia.Name = "dongia";
            dongia.ReadOnly = true;
            // 
            // FmLoaisach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(701, 382);
            Controls.Add(dtgvLoaisach);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txbG);
            Controls.Add(label3);
            Controls.Add(txbS);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmLoaisach";
            Text = "FmLoaisach";
            Load += FmLoaisach_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLoaisach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbS;
        private Label label3;
        private TextBox txbG;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dtgvLoaisach;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tentheloai;
        private DataGridViewTextBoxColumn dongia;
    }
}