namespace Quanh1
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
            label2 = new Label();
            txtSo1 = new TextBox();
            label3 = new Label();
            txtSo2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btCong = new RadioButton();
            btTru = new RadioButton();
            btNhan = new RadioButton();
            btChia = new RadioButton();
            btDu = new RadioButton();
            label6 = new Label();
            lbKetqua = new Label();
            btTinh = new Button();
            btDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 65);
            label1.TabIndex = 0;
            label1.Text = "CÁC PHÉP TOÁN CƠ BẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 100);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "số thứ 1:";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(170, 93);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 2;
            txtSo1.TextChanged += txtSo1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 104);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "số thứ 2:";
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(497, 97);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(200, 146);
            label4.Name = "label4";
            label4.Size = new Size(383, 155);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(200, 146);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 4;
            label5.Text = "Chọn phép toán:";
            // 
            // btCong
            // 
            btCong.AutoSize = true;
            btCong.BackColor = Color.FromArgb(255, 224, 192);
            btCong.Location = new Point(227, 228);
            btCong.Name = "btCong";
            btCong.Size = new Size(40, 24);
            btCong.TabIndex = 5;
            btCong.TabStop = true;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = false;
            // 
            // btTru
            // 
            btTru.AutoSize = true;
            btTru.BackColor = Color.FromArgb(255, 224, 192);
            btTru.Location = new Point(294, 228);
            btTru.Name = "btTru";
            btTru.Size = new Size(36, 24);
            btTru.TabIndex = 5;
            btTru.TabStop = true;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = false;
            // 
            // btNhan
            // 
            btNhan.AutoSize = true;
            btNhan.BackColor = Color.FromArgb(255, 224, 192);
            btNhan.Location = new Point(351, 228);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(37, 24);
            btNhan.TabIndex = 5;
            btNhan.TabStop = true;
            btNhan.Text = "x";
            btNhan.UseVisualStyleBackColor = false;
            // 
            // btChia
            // 
            btChia.AutoSize = true;
            btChia.BackColor = Color.FromArgb(255, 224, 192);
            btChia.Location = new Point(412, 228);
            btChia.Name = "btChia";
            btChia.Size = new Size(36, 24);
            btChia.TabIndex = 5;
            btChia.TabStop = true;
            btChia.Text = "/";
            btChia.UseVisualStyleBackColor = false;
            // 
            // btDu
            // 
            btDu.AutoSize = true;
            btDu.BackColor = Color.FromArgb(255, 224, 192);
            btDu.Location = new Point(467, 228);
            btDu.Name = "btDu";
            btDu.Size = new Size(42, 24);
            btDu.TabIndex = 5;
            btDu.TabStop = true;
            btDu.Text = "%";
            btDu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 343);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 6;
            label6.Text = "Kết quả:";
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = Color.FromArgb(255, 224, 192);
            lbKetqua.Location = new Point(179, 320);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(369, 43);
            lbKetqua.TabIndex = 7;
            // 
            // btTinh
            // 
            btTinh.BackColor = Color.Silver;
            btTinh.Location = new Point(587, 320);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(67, 43);
            btTinh.TabIndex = 8;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = false;
            btTinh.Click += btTinh_Click;
            // 
            // btDong
            // 
            btDong.BackColor = Color.Silver;
            btDong.Location = new Point(689, 320);
            btDong.Name = "btDong";
            btDong.Size = new Size(63, 40);
            btDong.TabIndex = 9;
            btDong.Text = "Đóng";
            btDong.UseVisualStyleBackColor = false;
            btDong.Click += btDong_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btDong);
            Controls.Add(btTinh);
            Controls.Add(lbKetqua);
            Controls.Add(label6);
            Controls.Add(btDu);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSo2);
            Controls.Add(label3);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private Label label3;
        private TextBox txtSo2;
        private Label label4;
        private Label label5;
        private RadioButton btCong;
        private RadioButton btTru;
        private RadioButton btNhan;
        private RadioButton btChia;
        private RadioButton btDu;
        private Label label6;
        private Label lbKetqua;
        private Button btTinh;
        private Button btDong;
    }
}