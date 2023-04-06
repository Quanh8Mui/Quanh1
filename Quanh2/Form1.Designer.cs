namespace Quanh2
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
            lbs1 = new Label();
            lbs2 = new Label();
            lbs3 = new Label();
            bt3 = new Button();
            button1 = new Button();
            lbKetqua = new Label();
            btQuayso = new Button();
            rd3 = new RadioButton();
            rd10 = new RadioButton();
            SuspendLayout();
            // 
            // lbs1
            // 
            lbs1.BackColor = Color.FromArgb(224, 224, 224);
            lbs1.Location = new Point(91, 49);
            lbs1.Name = "lbs1";
            lbs1.Size = new Size(163, 165);
            lbs1.TabIndex = 0;
            // 
            // lbs2
            // 
            lbs2.BackColor = Color.FromArgb(224, 224, 224);
            lbs2.Location = new Point(303, 49);
            lbs2.Name = "lbs2";
            lbs2.Size = new Size(163, 165);
            lbs2.TabIndex = 0;
            // 
            // lbs3
            // 
            lbs3.BackColor = Color.FromArgb(224, 224, 224);
            lbs3.Location = new Point(509, 49);
            lbs3.Name = "lbs3";
            lbs3.Size = new Size(163, 165);
            lbs3.TabIndex = 0;
            // 
            // bt3
            // 
            bt3.BackColor = SystemColors.ActiveBorder;
            bt3.Location = new Point(2, 226);
            bt3.Name = "bt3";
            bt3.Size = new Size(94, 42);
            bt3.TabIndex = 1;
            bt3.Text = "3-10";
            bt3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(2, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 1;
            button1.Text = "11-18";
            button1.UseVisualStyleBackColor = false;
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = SystemColors.ActiveCaption;
            lbKetqua.Location = new Point(584, 324);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(88, 85);
            lbKetqua.TabIndex = 2;
            // 
            // btQuayso
            // 
            btQuayso.Location = new Point(102, 368);
            btQuayso.Name = "btQuayso";
            btQuayso.Size = new Size(94, 29);
            btQuayso.TabIndex = 3;
            btQuayso.Text = "Quay số";
            btQuayso.UseVisualStyleBackColor = true;
            btQuayso.Click += btQuayso_Click;
            // 
            // rd3
            // 
            rd3.AutoSize = true;
            rd3.Location = new Point(151, 263);
            rd3.Name = "rd3";
            rd3.Size = new Size(60, 24);
            rd3.TabIndex = 4;
            rd3.TabStop = true;
            rd3.Text = "3-10";
            rd3.UseVisualStyleBackColor = true;
            rd3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rd10
            // 
            rd10.AutoSize = true;
            rd10.Location = new Point(274, 263);
            rd10.Name = "rd10";
            rd10.Size = new Size(68, 24);
            rd10.TabIndex = 4;
            rd10.TabStop = true;
            rd10.Text = "11-18";
            rd10.UseVisualStyleBackColor = true;
            rd10.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rd10);
            Controls.Add(rd3);
            Controls.Add(btQuayso);
            Controls.Add(lbKetqua);
            Controls.Add(button1);
            Controls.Add(bt3);
            Controls.Add(lbs3);
            Controls.Add(lbs2);
            Controls.Add(lbs1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbs1;
        private Label lbs2;
        private Label lbs3;
        private Button bt3;
        private Button button1;
        private Label lbKetqua;
        private Button btQuayso;
        private RadioButton rd3;
        private RadioButton rd10;
    }
}