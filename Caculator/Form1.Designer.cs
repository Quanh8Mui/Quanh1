namespace Caculator
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
            txtTinh = new TextBox();
            btDel = new Button();
            btReset = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            bt0 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            btBang = new Button();
            btCong = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 54);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTinh
            // 
            txtTinh.BackColor = SystemColors.InactiveCaptionText;
            txtTinh.ForeColor = SystemColors.Window;
            txtTinh.Location = new Point(27, 75);
            txtTinh.Multiline = true;
            txtTinh.Name = "txtTinh";
            txtTinh.Size = new Size(281, 60);
            txtTinh.TabIndex = 1;
            // 
            // btDel
            // 
            btDel.Location = new Point(27, 184);
            btDel.Name = "btDel";
            btDel.Size = new Size(77, 29);
            btDel.TabIndex = 2;
            btDel.Text = "DEL";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(213, 184);
            btReset.Name = "btReset";
            btReset.Size = new Size(77, 29);
            btReset.TabIndex = 2;
            btReset.Text = "R";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 260);
            button3.Name = "button3";
            button3.Size = new Size(63, 33);
            button3.TabIndex = 2;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(27, 299);
            button4.Name = "button4";
            button4.Size = new Size(63, 33);
            button4.TabIndex = 2;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += bt0_Click;
            // 
            // button5
            // 
            button5.Location = new Point(27, 338);
            button5.Name = "button5";
            button5.Size = new Size(63, 33);
            button5.TabIndex = 2;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += bt0_Click;
            // 
            // button6
            // 
            button6.Location = new Point(27, 377);
            button6.Name = "button6";
            button6.Size = new Size(63, 33);
            button6.TabIndex = 2;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(27, 260);
            button7.Name = "button7";
            button7.Size = new Size(63, 33);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += bt0_Click;
            // 
            // bt0
            // 
            bt0.Location = new Point(27, 377);
            bt0.Name = "bt0";
            bt0.Size = new Size(63, 33);
            bt0.TabIndex = 2;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // button9
            // 
            button9.Location = new Point(96, 260);
            button9.Name = "button9";
            button9.Size = new Size(63, 33);
            button9.TabIndex = 2;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += bt0_Click;
            // 
            // button10
            // 
            button10.Location = new Point(96, 299);
            button10.Name = "button10";
            button10.Size = new Size(63, 33);
            button10.TabIndex = 2;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += bt0_Click;
            // 
            // button11
            // 
            button11.Location = new Point(96, 338);
            button11.Name = "button11";
            button11.Size = new Size(63, 33);
            button11.TabIndex = 2;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += bt0_Click;
            // 
            // button12
            // 
            button12.Location = new Point(165, 338);
            button12.Name = "button12";
            button12.Size = new Size(63, 33);
            button12.TabIndex = 2;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += bt0_Click;
            // 
            // button13
            // 
            button13.Location = new Point(165, 299);
            button13.Name = "button13";
            button13.Size = new Size(63, 33);
            button13.TabIndex = 2;
            button13.Text = "6";
            button13.UseVisualStyleBackColor = true;
            button13.Click += bt0_Click;
            // 
            // button14
            // 
            button14.Location = new Point(165, 260);
            button14.Name = "button14";
            button14.Size = new Size(63, 33);
            button14.TabIndex = 2;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = true;
            button14.Click += bt0_Click;
            // 
            // btBang
            // 
            btBang.Location = new Point(96, 377);
            btBang.Name = "btBang";
            btBang.Size = new Size(132, 33);
            btBang.TabIndex = 2;
            btBang.Text = "=";
            btBang.UseVisualStyleBackColor = true;
            btBang.Click += btBang_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(234, 260);
            btCong.Name = "btCong";
            btCong.Size = new Size(83, 33);
            btCong.TabIndex = 2;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // button17
            // 
            button17.Location = new Point(234, 299);
            button17.Name = "button17";
            button17.Size = new Size(83, 33);
            button17.TabIndex = 2;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(234, 338);
            button18.Name = "button18";
            button18.Size = new Size(83, 33);
            button18.TabIndex = 2;
            button18.Text = "x";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(234, 377);
            button19.Name = "button19";
            button19.Size = new Size(83, 33);
            button19.TabIndex = 2;
            button19.Text = ":";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(344, 450);
            Controls.Add(btReset);
            Controls.Add(bt0);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(btCong);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(btBang);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btDel);
            Controls.Add(txtTinh);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SimpleCulator";
            Click += bt0_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTinh;
        private Button btDel;
        private Button btReset;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button bt0;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btBang;
        private Button btCong;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}