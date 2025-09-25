namespace window_forms_a_stupid_calculator
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxDisplay = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            equalsButton = new Button();
            clearButton = new Button();
            sqrtButton = new Button();
            percentButton = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(10, 40);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.Size = new Size(260, 29);
            textBoxDisplay.TabIndex = 1;
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button0
            // 
            button0.Location = new Point(12, 300);
            button0.Name = "button0";
            button0.Size = new Size(104, 36);
            button0.TabIndex = 2;
            button0.Text = "0";
            button0.Click += DigitButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 254);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.Click += DigitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 254);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(122, 254);
            button3.Name = "button3";
            button3.Size = new Size(50, 40);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 208);
            button4.Name = "button4";
            button4.Size = new Size(50, 40);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(66, 208);
            button5.Name = "button5";
            button5.Size = new Size(50, 40);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(122, 208);
            button6.Name = "button6";
            button6.Size = new Size(50, 40);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 162);
            button7.Name = "button7";
            button7.Size = new Size(50, 40);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(66, 162);
            button8.Name = "button8";
            button8.Size = new Size(50, 40);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(122, 162);
            button9.Name = "button9";
            button9.Size = new Size(50, 40);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.Click += DigitButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(178, 162);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 40);
            addButton.TabIndex = 12;
            addButton.Text = "+";
            addButton.Click += OperationButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(178, 208);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(50, 40);
            subtractButton.TabIndex = 13;
            subtractButton.Text = "-";
            subtractButton.Click += OperationButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(178, 254);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(50, 40);
            multiplyButton.TabIndex = 14;
            multiplyButton.Text = "*";
            multiplyButton.Click += OperationButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(178, 296);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(50, 40);
            divideButton.TabIndex = 15;
            divideButton.Text = "/";
            divideButton.Click += OperationButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Location = new Point(122, 298);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(50, 40);
            equalsButton.TabIndex = 16;
            equalsButton.Text = "=";
            equalsButton.Click += EqualsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(178, 342);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(50, 40);
            clearButton.TabIndex = 17;
            clearButton.Text = "C";
            clearButton.Click += ClearButton_Click;
            // 
            // sqrtButton
            // 
            sqrtButton.Location = new Point(12, 342);
            sqrtButton.Name = "sqrtButton";
            sqrtButton.Size = new Size(50, 40);
            sqrtButton.TabIndex = 18;
            sqrtButton.Text = "√";
            sqrtButton.Click += SqrtButton_Click;
            // 
            // percentButton
            // 
            percentButton.Location = new Point(68, 342);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(50, 40);
            percentButton.TabIndex = 19;
            percentButton.Text = "%";
            percentButton.Click += PercentButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(288, 397);
            Controls.Add(textBoxDisplay);
            Controls.Add(button0);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(addButton);
            Controls.Add(subtractButton);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(equalsButton);
            Controls.Add(clearButton);
            Controls.Add(sqrtButton);
            Controls.Add(percentButton);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Calculator";
            Text = "Simple Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxDisplay;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button equalsButton;
        private Button clearButton;
        private Button sqrtButton;
        private Button percentButton;
    }
}