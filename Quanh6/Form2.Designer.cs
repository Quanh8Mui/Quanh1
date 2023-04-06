namespace Quanh6
{
    partial class Form2
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
            btDangnhap = new Button();
            txtDangnhap = new TextBox();
            label2 = new Label();
            txtMatkhau = new TextBox();
            btDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 70);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // btDangnhap
            // 
            btDangnhap.Location = new Point(147, 244);
            btDangnhap.Name = "btDangnhap";
            btDangnhap.Size = new Size(87, 51);
            btDangnhap.TabIndex = 1;
            btDangnhap.Text = "Đăng nhập";
            btDangnhap.UseVisualStyleBackColor = true;
            btDangnhap.Click += btDangnhap_Click;
            // 
            // txtDangnhap
            // 
            txtDangnhap.Location = new Point(219, 70);
            txtDangnhap.Name = "txtDangnhap";
            txtDangnhap.Size = new Size(192, 27);
            txtDangnhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 151);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(219, 144);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(192, 27);
            txtMatkhau.TabIndex = 2;
            // 
            // btDong
            // 
            btDong.Location = new Point(300, 244);
            btDong.Name = "btDong";
            btDong.Size = new Size(87, 51);
            btDong.TabIndex = 1;
            btDong.Text = "Đóng";
            btDong.UseVisualStyleBackColor = true;
            btDong.Click += btDong_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMatkhau);
            Controls.Add(txtDangnhap);
            Controls.Add(btDong);
            Controls.Add(btDangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Đăng nhập";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btDangnhap;
        private TextBox txtDangnhap;
        private Label label2;
        private TextBox txtMatkhau;
        private Button btDong;
    }
}