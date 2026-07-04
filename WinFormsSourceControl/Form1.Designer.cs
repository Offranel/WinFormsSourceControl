namespace WinFormsSourceControl
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
            LengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            calcAreaAndPerimeterButton = new Button();
            areaTextBox = new TextBox();
            perimeterTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 161);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(152, 46);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(250, 47);
            LengthTextBox.TabIndex = 2;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(152, 158);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(250, 47);
            widthTextBox.TabIndex = 3;
            // 
            // calcAreaAndPerimeterButton
            // 
            calcAreaAndPerimeterButton.Location = new Point(134, 273);
            calcAreaAndPerimeterButton.Name = "calcAreaAndPerimeterButton";
            calcAreaAndPerimeterButton.Size = new Size(297, 128);
            calcAreaAndPerimeterButton.TabIndex = 4;
            calcAreaAndPerimeterButton.Text = "Calculate and Perimeter";
            calcAreaAndPerimeterButton.UseVisualStyleBackColor = true;
            calcAreaAndPerimeterButton.Click += CalcAreaAndPerimeterButton_Click;
            // 
            // areaTextBox
            // 
            areaTextBox.Location = new Point(498, 199);
            areaTextBox.Name = "areaTextBox";
            areaTextBox.ReadOnly = true;
            areaTextBox.Size = new Size(250, 47);
            areaTextBox.TabIndex = 5;
            // 
            // perimeterTextBox
            // 
            perimeterTextBox.Location = new Point(498, 314);
            perimeterTextBox.Name = "perimeterTextBox";
            perimeterTextBox.ReadOnly = true;
            perimeterTextBox.Size = new Size(250, 47);
            perimeterTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(perimeterTextBox);
            Controls.Add(areaTextBox);
            Controls.Add(calcAreaAndPerimeterButton);
            Controls.Add(widthTextBox);
            Controls.Add(LengthTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Area and Perimeter Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LengthTextBox;
        private TextBox widthTextBox;
        private Button calcAreaAndPerimeterButton;
        private TextBox areaTextBox;
        private TextBox perimeterTextBox;
    }
}
