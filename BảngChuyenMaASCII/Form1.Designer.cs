namespace BảngChuyenMaASCII
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            lbKetqua1 = new Label();
            label4 = new Label();
            btChuyen1 = new Button();
            txtMa = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            lbKetqua2 = new Label();
            label5 = new Label();
            btChuyen2 = new Button();
            txtKytu = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(802, 64);
            label1.TabIndex = 0;
            label1.Text = "CHUYỂN MÃ ASCII";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbKetqua1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btChuyen1);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(61, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 216);
            panel1.TabIndex = 1;
            // 
            // lbKetqua1
            // 
            lbKetqua1.BackColor = Color.FromArgb(128, 128, 255);
            lbKetqua1.Location = new Point(119, 154);
            lbKetqua1.Name = "lbKetqua1";
            lbKetqua1.Size = new Size(135, 25);
            lbKetqua1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "kết quả:";
            // 
            // btChuyen1
            // 
            btChuyen1.BackColor = SystemColors.ActiveBorder;
            btChuyen1.Location = new Point(128, 81);
            btChuyen1.Name = "btChuyen1";
            btChuyen1.Size = new Size(79, 44);
            btChuyen1.TabIndex = 2;
            btChuyen1.Text = "Chuyển";
            btChuyen1.UseVisualStyleBackColor = false;
            btChuyen1.Click += btChuyen1_Click;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(119, 38);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(125, 27);
            txtMa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 45);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "mã ascii";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbKetqua2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btChuyen2);
            panel2.Controls.Add(txtKytu);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(421, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 219);
            panel2.TabIndex = 2;
            // 
            // lbKetqua2
            // 
            lbKetqua2.BackColor = Color.FromArgb(128, 128, 255);
            lbKetqua2.Location = new Point(108, 154);
            lbKetqua2.Name = "lbKetqua2";
            lbKetqua2.Size = new Size(135, 25);
            lbKetqua2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 159);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 3;
            label5.Text = "kết quả:";
            // 
            // btChuyen2
            // 
            btChuyen2.BackColor = SystemColors.ActiveBorder;
            btChuyen2.Location = new Point(125, 81);
            btChuyen2.Name = "btChuyen2";
            btChuyen2.Size = new Size(79, 44);
            btChuyen2.TabIndex = 2;
            btChuyen2.Text = "Chuyển";
            btChuyen2.UseVisualStyleBackColor = false;
            btChuyen2.Click += btChuyen2_Click;
            // 
            // txtKytu
            // 
            txtKytu.Location = new Point(79, 38);
            txtKytu.Name = "txtKytu";
            txtKytu.Size = new Size(125, 27);
            txtKytu.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 45);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 0;
            label3.Text = "ký tự";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label lbKetqua1;
        private Label label4;
        private Button btChuyen1;
        private TextBox txtMa;
        private Label lbKetqua2;
        private Label label5;
        private Button btChuyen2;
        private TextBox txtKytu;
    }
}