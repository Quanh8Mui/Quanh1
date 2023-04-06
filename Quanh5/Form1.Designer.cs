namespace Quanh5
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
            components = new System.ComponentModel.Container();
            lbName = new Label();
            picSo1 = new PictureBox();
            picSo2 = new PictureBox();
            picSo3 = new PictureBox();
            button1 = new Button();
            btDiem = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picSo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSo3).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.BackColor = Color.FromArgb(128, 255, 255);
            lbName.Dock = DockStyle.Top;
            lbName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(0, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(800, 70);
            lbName.TabIndex = 0;
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picSo1
            // 
            picSo1.Location = new Point(63, 109);
            picSo1.Name = "picSo1";
            picSo1.Size = new Size(141, 152);
            picSo1.TabIndex = 1;
            picSo1.TabStop = false;
            // 
            // picSo2
            // 
            picSo2.Location = new Point(300, 109);
            picSo2.Name = "picSo2";
            picSo2.Size = new Size(141, 152);
            picSo2.TabIndex = 1;
            picSo2.TabStop = false;
            // 
            // picSo3
            // 
            picSo3.Location = new Point(559, 109);
            picSo3.Name = "picSo3";
            picSo3.Size = new Size(141, 152);
            picSo3.TabIndex = 1;
            picSo3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(134, 302);
            button1.Name = "button1";
            button1.Size = new Size(70, 72);
            button1.TabIndex = 2;
            button1.Text = "Quay số";
            button1.UseVisualStyleBackColor = true;
            // 
            // btDiem
            // 
            btDiem.Location = new Point(288, 302);
            btDiem.Name = "btDiem";
            btDiem.Size = new Size(70, 72);
            btDiem.TabIndex = 2;
            btDiem.Text = "0";
            btDiem.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btDiem);
            Controls.Add(button1);
            Controls.Add(picSo3);
            Controls.Add(picSo2);
            Controls.Add(picSo1);
            Controls.Add(lbName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSo3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private PictureBox picSo1;
        private PictureBox picSo2;
        private PictureBox picSo3;
        private Button button1;
        private Button btDiem;
        private System.Windows.Forms.Timer timer1;
    }
}