namespace ConverterForm
{
    partial class ConverterForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            userCurrency = new TextBox();
            currencyOptions = new ComboBox();
            convertCurrency = new ComboBox();
            convertNumberLabel = new Label();
            convertTempLabel = new Label();
            convertTemp = new ComboBox();
            tempOptions = new ComboBox();
            userTemp = new TextBox();
            convertCurrencyButton = new Button();
            convertTempButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(776, 30);
            label1.TabIndex = 0;
            label1.Text = "Convert Your Numbers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.currency;
            pictureBox1.Location = new Point(97, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.temperature;
            pictureBox2.Location = new Point(525, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // userCurrency
            // 
            userCurrency.BackColor = Color.Black;
            userCurrency.ForeColor = Color.White;
            userCurrency.Location = new Point(97, 284);
            userCurrency.Name = "userCurrency";
            userCurrency.Size = new Size(87, 23);
            userCurrency.TabIndex = 3;
            userCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // currencyOptions
            // 
            currencyOptions.BackColor = Color.Black;
            currencyOptions.ForeColor = Color.White;
            currencyOptions.FormattingEnabled = true;
            currencyOptions.Items.AddRange(new object[] { "Real", "Dolar", "Euro" });
            currencyOptions.Location = new Point(190, 284);
            currencyOptions.Name = "currencyOptions";
            currencyOptions.Size = new Size(78, 23);
            currencyOptions.TabIndex = 4;
            // 
            // convertCurrency
            // 
            convertCurrency.BackColor = Color.Black;
            convertCurrency.ForeColor = Color.White;
            convertCurrency.FormattingEnabled = true;
            convertCurrency.Items.AddRange(new object[] { "Real", "Dolar", "Euro" });
            convertCurrency.Location = new Point(190, 394);
            convertCurrency.Name = "convertCurrency";
            convertCurrency.Size = new Size(78, 23);
            convertCurrency.TabIndex = 5;
            // 
            // convertNumberLabel
            // 
            convertNumberLabel.BorderStyle = BorderStyle.FixedSingle;
            convertNumberLabel.Location = new Point(97, 394);
            convertNumberLabel.Name = "convertNumberLabel";
            convertNumberLabel.Size = new Size(87, 23);
            convertNumberLabel.TabIndex = 6;
            convertNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertTempLabel
            // 
            convertTempLabel.BorderStyle = BorderStyle.FixedSingle;
            convertTempLabel.Location = new Point(525, 393);
            convertTempLabel.Name = "convertTempLabel";
            convertTempLabel.Size = new Size(87, 23);
            convertTempLabel.TabIndex = 10;
            convertTempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertTemp
            // 
            convertTemp.BackColor = Color.Black;
            convertTemp.ForeColor = Color.White;
            convertTemp.FormattingEnabled = true;
            convertTemp.Location = new Point(618, 393);
            convertTemp.Name = "convertTemp";
            convertTemp.Size = new Size(78, 23);
            convertTemp.TabIndex = 9;
            // 
            // tempOptions
            // 
            tempOptions.BackColor = Color.Black;
            tempOptions.ForeColor = Color.White;
            tempOptions.FormattingEnabled = true;
            tempOptions.Location = new Point(618, 284);
            tempOptions.Name = "tempOptions";
            tempOptions.Size = new Size(78, 23);
            tempOptions.TabIndex = 8;
            // 
            // userTemp
            // 
            userTemp.BackColor = Color.Black;
            userTemp.ForeColor = Color.White;
            userTemp.Location = new Point(525, 284);
            userTemp.Name = "userTemp";
            userTemp.Size = new Size(87, 23);
            userTemp.TabIndex = 7;
            userTemp.TextAlign = HorizontalAlignment.Center;
            // 
            // convertCurrencyButton
            // 
            convertCurrencyButton.BackColor = Color.Black;
            convertCurrencyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertCurrencyButton.Location = new Point(134, 338);
            convertCurrencyButton.Name = "convertCurrencyButton";
            convertCurrencyButton.Size = new Size(98, 31);
            convertCurrencyButton.TabIndex = 11;
            convertCurrencyButton.Text = "Convert";
            convertCurrencyButton.TextAlign = ContentAlignment.TopCenter;
            convertCurrencyButton.UseVisualStyleBackColor = false;
            convertCurrencyButton.Click += convertCurrencyButton_Click;
            // 
            // convertTempButton
            // 
            convertTempButton.BackColor = Color.Black;
            convertTempButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertTempButton.Location = new Point(568, 338);
            convertTempButton.Name = "convertTempButton";
            convertTempButton.Size = new Size(98, 31);
            convertTempButton.TabIndex = 12;
            convertTempButton.Text = "Convert";
            convertTempButton.TextAlign = ContentAlignment.TopCenter;
            convertTempButton.UseVisualStyleBackColor = false;
            convertTempButton.Click += convertTempButton_Click;
            // 
            // ConverterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(convertTempButton);
            Controls.Add(convertCurrencyButton);
            Controls.Add(convertTempLabel);
            Controls.Add(convertTemp);
            Controls.Add(tempOptions);
            Controls.Add(userTemp);
            Controls.Add(convertNumberLabel);
            Controls.Add(convertCurrency);
            Controls.Add(currencyOptions);
            Controls.Add(userCurrency);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            MaximizeBox = false;
            Name = "ConverterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency And Temperature Converter";
            Load += ConverterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox userCurrency;
        private ComboBox currencyOptions;
        private ComboBox convertCurrency;
        private Label convertNumberLabel;
        private Label convertTempLabel;
        private ComboBox convertTemp;
        private ComboBox tempOptions;
        private TextBox userTemp;
        private Button convertCurrencyButton;
        private Button convertTempButton;
    }
}
