namespace window_forms_a_stupid_calculator
{
    partial class Calculator
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-7, -3);
            label1.Name = "label1";
            label1.Size = new Size(497, 22);
            label1.TabIndex = 0;
            label1.Text = "DO NOT DIVIDE BY 0 OR YOU WILL SUMMON \"HIM\"";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 412);
            label2.Name = "label2";
            label2.Size = new Size(20, 22);
            label2.TabIndex = 1;
            label2.Text = "1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 368);
            label3.Name = "label3";
            label3.Size = new Size(20, 22);
            label3.TabIndex = 2;
            label3.Text = "8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 368);
            label4.Name = "label4";
            label4.Size = new Size(20, 22);
            label4.TabIndex = 3;
            label4.Text = "7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 346);
            label5.Name = "label5";
            label5.Size = new Size(20, 22);
            label5.TabIndex = 4;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 390);
            label6.Name = "label6";
            label6.Size = new Size(20, 22);
            label6.TabIndex = 5;
            label6.Text = "4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 368);
            label7.Name = "label7";
            label7.Size = new Size(20, 22);
            label7.TabIndex = 6;
            label7.Text = "9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 412);
            label8.Name = "label8";
            label8.Size = new Size(20, 22);
            label8.TabIndex = 7;
            label8.Text = "3";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(103, 390);
            label9.Name = "label9";
            label9.Size = new Size(20, 22);
            label9.TabIndex = 8;
            label9.Text = "6";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(68, 390);
            label10.Name = "label10";
            label10.Size = new Size(20, 22);
            label10.TabIndex = 9;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 412);
            label11.Name = "label11";
            label11.Size = new Size(20, 22);
            label11.TabIndex = 10;
            label11.Text = "2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(151, 412);
            label12.Name = "label12";
            label12.Size = new Size(21, 22);
            label12.TabIndex = 11;
            label12.Text = "=";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(129, 412);
            label13.Name = "label13";
            label13.Size = new Size(16, 22);
            label13.TabIndex = 12;
            label13.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(124, 390);
            label14.Name = "label14";
            label14.Size = new Size(21, 22);
            label14.TabIndex = 13;
            label14.Text = "+";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(124, 368);
            label15.Name = "label15";
            label15.Size = new Size(20, 22);
            label15.TabIndex = 14;
            label15.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(151, 390);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(15, 22);
            label16.TabIndex = 15;
            label16.Text = "/";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(303, 73);
            label17.Name = "label17";
            label17.Size = new Size(142, 22);
            label17.TabIndex = 16;
            label17.Text = "Placeholder text";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(484, 461);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Calculator";
            Text = "Suspicious Calculator";
            TransparencyKey = Color.Cyan;
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
