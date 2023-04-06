namespace GiaiPhuongTrinhBac2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            label5 = new Label();
            lbKetqua = new Label();
            btGiai = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(802, 56);
            label1.TabIndex = 0;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 135);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "a=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 135);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 1;
            label3.Text = "b=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 135);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 1;
            label4.Text = "c=";
            // 
            // txt1
            // 
            txt1.Location = new Point(98, 127);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Location = new Point(297, 127);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 2;
            // 
            // txt3
            // 
            txt3.Location = new Point(471, 127);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(73, 265);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 3;
            label5.Text = "Kết quả:";
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = Color.FromArgb(255, 255, 128);
            lbKetqua.ForeColor = SystemColors.ActiveCaptionText;
            lbKetqua.Location = new Point(177, 250);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(336, 46);
            lbKetqua.TabIndex = 4;
            // 
            // btGiai
            // 
            btGiai.BackColor = SystemColors.ActiveBorder;
            btGiai.Location = new Point(582, 260);
            btGiai.Name = "btGiai";
            btGiai.Size = new Size(94, 55);
            btGiai.TabIndex = 5;
            btGiai.Text = "Gỉai";
            btGiai.UseVisualStyleBackColor = false;
            btGiai.Click += btGiai_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Tieeps tuc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btGiai);
            Controls.Add(lbKetqua);
            Controls.Add(label5);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Label label5;
        private Label lbKetqua;
        private Button btGiai;
        private Button button1;
    }
}