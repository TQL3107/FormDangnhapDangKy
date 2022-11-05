namespace FormDangnhapDangKy
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Tendangnhap = new System.Windows.Forms.TextBox();
            this.tb_Matkhau = new System.Windows.Forms.TextBox();
            this.cb_Nguoimay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.lb_QuenMK = new System.Windows.Forms.Label();
            this.lb_Dangky = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Tendangnhap
            // 
            this.tb_Tendangnhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Tendangnhap.Location = new System.Drawing.Point(260, 31);
            this.tb_Tendangnhap.Name = "tb_Tendangnhap";
            this.tb_Tendangnhap.Size = new System.Drawing.Size(719, 31);
            this.tb_Tendangnhap.TabIndex = 0;
            // 
            // tb_Matkhau
            // 
            this.tb_Matkhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Matkhau.Location = new System.Drawing.Point(264, 119);
            this.tb_Matkhau.Name = "tb_Matkhau";
            this.tb_Matkhau.PasswordChar = '*';
            this.tb_Matkhau.Size = new System.Drawing.Size(713, 31);
            this.tb_Matkhau.TabIndex = 1;
            // 
            // cb_Nguoimay
            // 
            this.cb_Nguoimay.AutoSize = true;
            this.cb_Nguoimay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cb_Nguoimay.Location = new System.Drawing.Point(30, 216);
            this.cb_Nguoimay.Name = "cb_Nguoimay";
            this.cb_Nguoimay.Size = new System.Drawing.Size(245, 29);
            this.cb_Nguoimay.TabIndex = 2;
            this.cb_Nguoimay.Text = "Tôi không phải người máy";
            this.cb_Nguoimay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Dangnhap.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Dangnhap.Location = new System.Drawing.Point(30, 296);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(283, 58);
            this.btn_Dangnhap.TabIndex = 5;
            this.btn_Dangnhap.Text = "Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = false;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // lb_QuenMK
            // 
            this.lb_QuenMK.AutoSize = true;
            this.lb_QuenMK.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lb_QuenMK.ForeColor = System.Drawing.Color.Red;
            this.lb_QuenMK.Location = new System.Drawing.Point(757, 207);
            this.lb_QuenMK.Name = "lb_QuenMK";
            this.lb_QuenMK.Size = new System.Drawing.Size(220, 38);
            this.lb_QuenMK.TabIndex = 6;
            this.lb_QuenMK.Text = "Quên mật khẩu";
            this.lb_QuenMK.Click += new System.EventHandler(this.lb_QuenMK_Click);
            // 
            // lb_Dangky
            // 
            this.lb_Dangky.AutoSize = true;
            this.lb_Dangky.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_Dangky.Location = new System.Drawing.Point(476, 310);
            this.lb_Dangky.Name = "lb_Dangky";
            this.lb_Dangky.Size = new System.Drawing.Size(501, 38);
            this.lb_Dangky.TabIndex = 7;
            this.lb_Dangky.Text = "Chưa có tài khoản> ĐĂNG KÝ NGAY";
            this.lb_Dangky.Click += new System.EventHandler(this.lb_Dangky_Click);
            this.lb_Dangky.MouseLeave += new System.EventHandler(this.lb_Dangky_MouseLeave);
            this.lb_Dangky.MouseHover += new System.EventHandler(this.lb_Dangky_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1071, 399);
            this.Controls.Add(this.lb_Dangky);
            this.Controls.Add(this.lb_QuenMK);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Nguoimay);
            this.Controls.Add(this.tb_Matkhau);
            this.Controls.Add(this.tb_Tendangnhap);
            this.Name = "Login";
            this.Text = "Form đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Tendangnhap;
        private TextBox tb_Matkhau;
        private CheckBox cb_Nguoimay;
        private Label label1;
        private Label label2;
        private Button btn_Dangnhap;
        private Label lb_QuenMK;
        private Label lb_Dangky;
    }
}