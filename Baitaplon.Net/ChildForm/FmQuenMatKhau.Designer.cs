namespace Baitaplon.Net.ChildForm
{
    partial class FmQuenMatKhau
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
            txbEmail = new TextBox();
            txbOTP = new TextBox();
            button1 = new Button();
            btnXn = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Nhập OTP";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(148, 44);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(136, 23);
            txbEmail.TabIndex = 3;
            // 
            // txbOTP
            // 
            txbOTP.Location = new Point(148, 72);
            txbOTP.Name = "txbOTP";
            txbOTP.Size = new Size(69, 23);
            txbOTP.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(290, 43);
            button1.Name = "button1";
            button1.Size = new Size(42, 23);
            button1.TabIndex = 6;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnXn
            // 
            btnXn.Location = new Point(148, 141);
            btnXn.Name = "btnXn";
            btnXn.Size = new Size(69, 29);
            btnXn.TabIndex = 7;
            btnXn.Text = "Xác nhận";
            btnXn.UseVisualStyleBackColor = true;
            btnXn.Click += btnXn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(223, 141);
            button3.Name = "button3";
            button3.Size = new Size(69, 29);
            button3.TabIndex = 8;
            button3.Text = "Hủy";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 109);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 9;
            // 
            // FmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 139, 139);
            ClientSize = new Size(344, 216);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(btnXn);
            Controls.Add(button1);
            Controls.Add(txbOTP);
            Controls.Add(txbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmQuenMatKhau";
            Text = "FmQuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbEmail;
        private TextBox txbOTP;
        private Button button1;
        private Button btnXn;
        private Button button3;
        private Label label3;
    }
}