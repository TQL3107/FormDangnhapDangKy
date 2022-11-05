namespace FormDangnhapDangKy
{
    partial class Forgot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_Cancuoc = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào tên đăng nhập: .............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hẫy nhập Số căn cước của bạn:";
            // 
            // tbt_Cancuoc
            // 
            this.tbt_Cancuoc.Location = new System.Drawing.Point(317, 127);
            this.tbt_Cancuoc.Name = "tbt_Cancuoc";
            this.tbt_Cancuoc.Size = new System.Drawing.Size(510, 27);
            this.tbt_Cancuoc.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(317, 196);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(234, 48);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Lấy lại mật khẩu";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 344);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tbt_Cancuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgot";
            this.Text = "Forgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbt_Cancuoc;
        private Button btn_Reset;
    }
}