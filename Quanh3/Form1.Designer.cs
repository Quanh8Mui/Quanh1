namespace Quanh3
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
            panel1 = new Panel();
            txtMauso1 = new TextBox();
            txtTuso1 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            txtMauso2 = new TextBox();
            txtTuso2 = new TextBox();
            panel3 = new Panel();
            txtMauso3 = new TextBox();
            txtTuso3 = new TextBox();
            btCong = new Button();
            btTru = new Button();
            btNhan = new Button();
            btChia = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMauso1);
            panel1.Controls.Add(txtTuso1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(73, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 277);
            panel1.TabIndex = 0;
            // 
            // txtMauso1
            // 
            txtMauso1.Location = new Point(27, 180);
            txtMauso1.Name = "txtMauso1";
            txtMauso1.Size = new Size(125, 27);
            txtMauso1.TabIndex = 4;
            // 
            // txtTuso1
            // 
            txtTuso1.Location = new Point(27, 29);
            txtTuso1.Name = "txtTuso1";
            txtTuso1.Size = new Size(125, 27);
            txtTuso1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Location = new Point(831, 68);
            label5.Name = "label5";
            label5.Size = new Size(104, 71);
            label5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMauso2);
            panel2.Controls.Add(txtTuso2);
            panel2.Location = new Point(302, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 271);
            panel2.TabIndex = 1;
            // 
            // txtMauso2
            // 
            txtMauso2.Location = new Point(21, 174);
            txtMauso2.Name = "txtMauso2";
            txtMauso2.Size = new Size(125, 27);
            txtMauso2.TabIndex = 4;
            // 
            // txtTuso2
            // 
            txtTuso2.Location = new Point(21, 23);
            txtTuso2.Name = "txtTuso2";
            txtTuso2.Size = new Size(125, 27);
            txtTuso2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMauso3);
            panel3.Controls.Add(txtTuso3);
            panel3.Location = new Point(547, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 268);
            panel3.TabIndex = 2;
            // 
            // txtMauso3
            // 
            txtMauso3.Location = new Point(62, 177);
            txtMauso3.Name = "txtMauso3";
            txtMauso3.Size = new Size(125, 27);
            txtMauso3.TabIndex = 4;
            // 
            // txtTuso3
            // 
            txtTuso3.Location = new Point(62, 26);
            txtTuso3.Name = "txtTuso3";
            txtTuso3.Size = new Size(125, 27);
            txtTuso3.TabIndex = 4;
            // 
            // btCong
            // 
            btCong.Location = new Point(12, 333);
            btCong.Name = "btCong";
            btCong.Size = new Size(82, 61);
            btCong.TabIndex = 3;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btTru
            // 
            btTru.Location = new Point(100, 333);
            btTru.Name = "btTru";
            btTru.Size = new Size(82, 61);
            btTru.TabIndex = 3;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = true;
            btTru.Click += btTru_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(188, 333);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(82, 61);
            btNhan.TabIndex = 3;
            btNhan.Text = "x";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btChia
            // 
            btChia.Location = new Point(276, 333);
            btChia.Name = "btChia";
            btChia.Size = new Size(82, 61);
            btChia.TabIndex = 3;
            btChia.Text = ":";
            btChia.UseVisualStyleBackColor = true;
            btChia.Click += btChia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private Button btCong;
        private Button btTru;
        private Button btNhan;
        private Button btChia;
        private TextBox txtMauso1;
        private TextBox txtTuso1;
        private TextBox txtMauso2;
        private TextBox txtTuso2;
        private TextBox txtMauso3;
        private TextBox txtTuso3;
    }
}