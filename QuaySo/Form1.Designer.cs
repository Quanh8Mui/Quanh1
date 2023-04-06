namespace QuaySo
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
            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            lbKetqua = new Label();
            btPlay = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.BackColor = Color.FromArgb(255, 255, 192);
            lb1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.ForeColor = Color.Blue;
            lb1.Location = new Point(63, 47);
            lb1.Name = "lb1";
            lb1.Size = new Size(165, 151);
            lb1.TabIndex = 0;
            lb1.Text = "0";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            lb2.BackColor = Color.FromArgb(255, 255, 192);
            lb2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.ForeColor = Color.Blue;
            lb2.Location = new Point(296, 47);
            lb2.Name = "lb2";
            lb2.Size = new Size(165, 151);
            lb2.TabIndex = 0;
            lb2.Text = "0";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            lb3.BackColor = Color.FromArgb(255, 255, 192);
            lb3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.ForeColor = Color.Blue;
            lb3.Location = new Point(537, 47);
            lb3.Name = "lb3";
            lb3.Size = new Size(165, 151);
            lb3.TabIndex = 0;
            lb3.Text = "0";
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = Color.FromArgb(255, 255, 192);
            lbKetqua.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbKetqua.ForeColor = Color.Red;
            lbKetqua.Location = new Point(178, 249);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(429, 54);
            lbKetqua.TabIndex = 1;
            lbKetqua.Text = "0";
            lbKetqua.TextAlign = ContentAlignment.TopCenter;
            // 
            // btPlay
            // 
            btPlay.BackColor = Color.Silver;
            btPlay.ForeColor = Color.Blue;
            btPlay.Location = new Point(193, 337);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(94, 50);
            btPlay.TabIndex = 2;
            btPlay.Text = "Play";
            btPlay.UseVisualStyleBackColor = false;
            btPlay.Click += btPlay_Click;
            // 
            // btExit
            // 
            btExit.BackColor = SystemColors.ActiveBorder;
            btExit.ForeColor = Color.Blue;
            btExit.Location = new Point(438, 337);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 50);
            btExit.TabIndex = 2;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btExit);
            Controls.Add(btPlay);
            Controls.Add(lbKetqua);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lb1;
        private Label lb2;
        private Label lb3;
        private Label lbKetqua;
        private Button btPlay;
        private Button btExit;
    }
}