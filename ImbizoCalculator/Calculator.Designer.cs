namespace ImbizoCalculator
{
    partial class Calculator
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
            this.calculatorScreen = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorScreen
            // 
            this.calculatorScreen.Enabled = false;
            this.calculatorScreen.Location = new System.Drawing.Point(39, 28);
            this.calculatorScreen.Name = "calculatorScreen";
            this.calculatorScreen.Size = new System.Drawing.Size(100, 20);
            this.calculatorScreen.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(76, 64);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 23);
            this.equalsButton.TabIndex = 2;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(39, 94);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(30, 23);
            this.oneButton.TabIndex = 3;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(76, 94);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(31, 23);
            this.twoButton.TabIndex = 4;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(76, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(113, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(76, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.calculatorScreen);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calculatorScreen;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}