namespace Calculator
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            zeroButton = new Button();
            changeSignButton = new Button();
            decimalButton = new Button();
            additionButton = new Button();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            subtractionButton = new Button();
            equalsButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            sixButton = new Button();
            multiplicationButton = new Button();
            outputTextBox = new TextBox();
            sevenButton = new Button();
            eightButton = new Button();
            nineButton = new Button();
            divisionButton = new Button();
            clearButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            operActText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstText = new TextBox();
            operText = new TextBox();
            secondText = new TextBox();
            label4 = new Label();
            resultText = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1MinSize = 352;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2MinSize = 210;
            splitContainer1.Size = new Size(582, 353);
            splitContainer1.SplitterDistance = 352;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(zeroButton, 0, 4);
            tableLayoutPanel1.Controls.Add(changeSignButton, 1, 4);
            tableLayoutPanel1.Controls.Add(decimalButton, 2, 4);
            tableLayoutPanel1.Controls.Add(additionButton, 3, 4);
            tableLayoutPanel1.Controls.Add(oneButton, 0, 3);
            tableLayoutPanel1.Controls.Add(twoButton, 1, 3);
            tableLayoutPanel1.Controls.Add(threeButton, 2, 3);
            tableLayoutPanel1.Controls.Add(subtractionButton, 3, 3);
            tableLayoutPanel1.Controls.Add(equalsButton, 4, 3);
            tableLayoutPanel1.Controls.Add(fourButton, 0, 2);
            tableLayoutPanel1.Controls.Add(fiveButton, 1, 2);
            tableLayoutPanel1.Controls.Add(sixButton, 2, 2);
            tableLayoutPanel1.Controls.Add(multiplicationButton, 3, 2);
            tableLayoutPanel1.Controls.Add(outputTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(sevenButton, 0, 1);
            tableLayoutPanel1.Controls.Add(eightButton, 1, 1);
            tableLayoutPanel1.Controls.Add(nineButton, 2, 1);
            tableLayoutPanel1.Controls.Add(divisionButton, 3, 1);
            tableLayoutPanel1.Controls.Add(clearButton, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(350, 351);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // zeroButton
            // 
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            zeroButton.Location = new Point(5, 285);
            zeroButton.Margin = new Padding(5);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(60, 61);
            zeroButton.TabIndex = 16;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += NumButton_Click;
            // 
            // changeSignButton
            // 
            changeSignButton.Dock = DockStyle.Fill;
            changeSignButton.Enabled = false;
            changeSignButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            changeSignButton.Location = new Point(75, 285);
            changeSignButton.Margin = new Padding(5);
            changeSignButton.Name = "changeSignButton";
            changeSignButton.Size = new Size(60, 61);
            changeSignButton.TabIndex = 17;
            changeSignButton.Text = "+/-";
            changeSignButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            decimalButton.Dock = DockStyle.Fill;
            decimalButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            decimalButton.Location = new Point(145, 285);
            decimalButton.Margin = new Padding(5);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(60, 61);
            decimalButton.TabIndex = 18;
            decimalButton.Text = System.Globalization.CultureInfo.CurrentCulture
                                                                 .NumberFormat
                                                                 .CurrencyDecimalSeparator[0]
                                                                 .ToString();
            decimalButton.UseVisualStyleBackColor = true;
            decimalButton.Click += DecimalButton_Click;
            // 
            // additionButton
            // 
            additionButton.Dock = DockStyle.Fill;
            additionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            additionButton.Location = new Point(215, 285);
            additionButton.Margin = new Padding(5);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(60, 61);
            additionButton.TabIndex = 19;
            additionButton.Tag = Operation.Add;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = true;
            additionButton.Click += OperButton_Click;
            // 
            // oneButton
            // 
            oneButton.Dock = DockStyle.Fill;
            oneButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            oneButton.Location = new Point(5, 215);
            oneButton.Margin = new Padding(5);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(60, 60);
            oneButton.TabIndex = 11;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += NumButton_Click;
            // 
            // twoButton
            // 
            twoButton.Dock = DockStyle.Fill;
            twoButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            twoButton.Location = new Point(75, 215);
            twoButton.Margin = new Padding(5);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(60, 60);
            twoButton.TabIndex = 12;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += NumButton_Click;
            // 
            // threeButton
            // 
            threeButton.Dock = DockStyle.Fill;
            threeButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            threeButton.Location = new Point(145, 215);
            threeButton.Margin = new Padding(5);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(60, 60);
            threeButton.TabIndex = 13;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += NumButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.Dock = DockStyle.Fill;
            subtractionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            subtractionButton.Location = new Point(215, 215);
            subtractionButton.Margin = new Padding(5);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(60, 60);
            subtractionButton.TabIndex = 14;
            subtractionButton.Tag = Operation.Subtract;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = true;
            subtractionButton.Click += OperButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Dock = DockStyle.Fill;
            equalsButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            equalsButton.Location = new Point(285, 215);
            equalsButton.Margin = new Padding(5);
            equalsButton.Name = "equalsButton";
            tableLayoutPanel1.SetRowSpan(equalsButton, 2);
            equalsButton.Size = new Size(60, 131);
            equalsButton.TabIndex = 15;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += EqualsButton_Click;
            // 
            // fourButton
            // 
            fourButton.Dock = DockStyle.Fill;
            fourButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fourButton.Location = new Point(5, 145);
            fourButton.Margin = new Padding(5);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(60, 60);
            fourButton.TabIndex = 6;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += NumButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fiveButton.Location = new Point(75, 145);
            fiveButton.Margin = new Padding(5);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(60, 60);
            fiveButton.TabIndex = 7;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += NumButton_Click;
            // 
            // sixButton
            // 
            sixButton.Dock = DockStyle.Fill;
            sixButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            sixButton.Location = new Point(145, 145);
            sixButton.Margin = new Padding(5);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(60, 60);
            sixButton.TabIndex = 8;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += NumButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Dock = DockStyle.Fill;
            multiplicationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.Location = new Point(215, 145);
            multiplicationButton.Margin = new Padding(5);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(60, 60);
            multiplicationButton.TabIndex = 9;
            multiplicationButton.Tag = Operation.Multiply;
            multiplicationButton.Text = "*";
            multiplicationButton.UseVisualStyleBackColor = true;
            multiplicationButton.Click += OperButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(outputTextBox, 5);
            outputTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            outputTextBox.Location = new Point(3, 15);
            outputTextBox.MaxLength = 16;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(344, 39);
            outputTextBox.TabIndex = 0;
            outputTextBox.TextAlign = HorizontalAlignment.Right;
            outputTextBox.TextChanged += OutputTextBox_TextChanged;
            // 
            // sevenButton
            // 
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            sevenButton.Location = new Point(5, 75);
            sevenButton.Margin = new Padding(5);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(60, 60);
            sevenButton.TabIndex = 1;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += NumButton_Click;
            // 
            // eightButton
            // 
            eightButton.Dock = DockStyle.Fill;
            eightButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            eightButton.Location = new Point(75, 75);
            eightButton.Margin = new Padding(5);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(60, 60);
            eightButton.TabIndex = 2;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += NumButton_Click;
            // 
            // nineButton
            // 
            nineButton.Dock = DockStyle.Fill;
            nineButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nineButton.Location = new Point(145, 75);
            nineButton.Margin = new Padding(5);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(60, 60);
            nineButton.TabIndex = 3;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += NumButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Dock = DockStyle.Fill;
            divisionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            divisionButton.Location = new Point(215, 75);
            divisionButton.Margin = new Padding(5);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(60, 60);
            divisionButton.TabIndex = 4;
            divisionButton.Tag = Operation.Divide;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += OperButton_Click;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Fill;
            clearButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(285, 75);
            clearButton.Margin = new Padding(5);
            clearButton.Name = "clearButton";
            tableLayoutPanel1.SetRowSpan(clearButton, 2);
            clearButton.Size = new Size(60, 130);
            clearButton.TabIndex = 5;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(operActText, 1, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(firstText, 1, 0);
            tableLayoutPanel2.Controls.Add(operText, 1, 1);
            tableLayoutPanel2.Controls.Add(secondText, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(resultText, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(224, 351);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // operActText
            // 
            operActText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            operActText.Location = new Point(115, 247);
            operActText.Name = "operActText";
            operActText.ReadOnly = true;
            operActText.Size = new Size(106, 27);
            operActText.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "1stOperand:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 77);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Operation:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 135);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "2ndOperand:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // firstText
            // 
            firstText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstText.Location = new Point(115, 15);
            firstText.Name = "firstText";
            firstText.ReadOnly = true;
            firstText.Size = new Size(106, 27);
            firstText.TabIndex = 4;
            // 
            // operText
            // 
            operText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            operText.Location = new Point(115, 73);
            operText.Name = "operText";
            operText.ReadOnly = true;
            operText.Size = new Size(106, 27);
            operText.TabIndex = 5;
            // 
            // secondText
            // 
            secondText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            secondText.Location = new Point(115, 131);
            secondText.Name = "secondText";
            secondText.ReadOnly = true;
            secondText.Size = new Size(106, 27);
            secondText.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 193);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 3;
            label4.Text = "Result:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // resultText
            // 
            resultText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            resultText.Location = new Point(115, 189);
            resultText.Name = "resultText";
            resultText.ReadOnly = true;
            resultText.Size = new Size(106, 27);
            resultText.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 251);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 8;
            label5.Text = "operActive:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            Text = "Demo Calculator";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox outputTextBox;
        private Button zeroButton;
        private Button changeSignButton;
        private Button decimalButton;
        private Button additionButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button subtractionButton;
        private Button equalsButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button multiplicationButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button divisionButton;
        private Button clearButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstText;
        private TextBox operText;
        private TextBox secondText;
        private TextBox resultText;
        private TextBox operActText;
        private Label label5;
    }
}