namespace lb3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedFile = new System.Windows.Forms.TextBox();
            this.EncOrDec = new System.Windows.Forms.ComboBox();
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueP = new System.Windows.Forms.TextBox();
            this.ValueX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateOpenKeyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FileInfoOrig = new System.Windows.Forms.TextBox();
            this.FileInfoEncrypted = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CleanAllButton = new System.Windows.Forms.Button();
            this.PrimitiveValue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранный файл";
            // 
            // SelectedFile
            // 
            this.SelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFile.Location = new System.Drawing.Point(23, 43);
            this.SelectedFile.Multiline = true;
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.ReadOnly = true;
            this.SelectedFile.Size = new System.Drawing.Size(145, 30);
            this.SelectedFile.TabIndex = 1;
            // 
            // EncOrDec
            // 
            this.EncOrDec.FormattingEnabled = true;
            this.EncOrDec.Location = new System.Drawing.Point(24, 79);
            this.EncOrDec.Name = "EncOrDec";
            this.EncOrDec.Size = new System.Drawing.Size(144, 24);
            this.EncOrDec.TabIndex = 2;
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileSelectionButton.Location = new System.Drawing.Point(190, 42);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.FileSelectionButton.Size = new System.Drawing.Size(105, 30);
            this.FileSelectionButton.TabIndex = 3;
            this.FileSelectionButton.Text = "Обзор";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Значение p";
            // 
            // ValueP
            // 
            this.ValueP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueP.Location = new System.Drawing.Point(336, 35);
            this.ValueP.Multiline = true;
            this.ValueP.Name = "ValueP";
            this.ValueP.Size = new System.Drawing.Size(145, 31);
            this.ValueP.TabIndex = 5;
            // 
            // ValueX
            // 
            this.ValueX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueX.Location = new System.Drawing.Point(337, 89);
            this.ValueX.Multiline = true;
            this.ValueX.Name = "ValueX";
            this.ValueX.Size = new System.Drawing.Size(145, 30);
            this.ValueX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(336, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значение x";
            // 
            // ValueK
            // 
            this.ValueK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueK.Location = new System.Drawing.Point(336, 147);
            this.ValueK.Multiline = true;
            this.ValueK.Name = "ValueK";
            this.ValueK.Size = new System.Drawing.Size(145, 30);
            this.ValueK.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(335, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Значение k";
            // 
            // OpenKey
            // 
            this.OpenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenKey.Location = new System.Drawing.Point(25, 217);
            this.OpenKey.Multiline = true;
            this.OpenKey.Name = "OpenKey";
            this.OpenKey.Size = new System.Drawing.Size(284, 30);
            this.OpenKey.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Открытый ключ (p, g, y) ";
            // 
            // CalculateOpenKeyButton
            // 
            this.CalculateOpenKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateOpenKeyButton.Location = new System.Drawing.Point(190, 147);
            this.CalculateOpenKeyButton.Name = "CalculateOpenKeyButton";
            this.CalculateOpenKeyButton.Size = new System.Drawing.Size(105, 30);
            this.CalculateOpenKeyButton.TabIndex = 12;
            this.CalculateOpenKeyButton.Text = "Рассчитать";
            this.CalculateOpenKeyButton.UseVisualStyleBackColor = true;
            this.CalculateOpenKeyButton.Click += new System.EventHandler(this.CalculateOpenKeyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Input";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Output\r\n";
            // 
            // FileInfoOrig
            // 
            this.FileInfoOrig.Location = new System.Drawing.Point(26, 285);
            this.FileInfoOrig.Multiline = true;
            this.FileInfoOrig.Name = "FileInfoOrig";
            this.FileInfoOrig.ReadOnly = true;
            this.FileInfoOrig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileInfoOrig.Size = new System.Drawing.Size(455, 77);
            this.FileInfoOrig.TabIndex = 15;
            // 
            // FileInfoEncrypted
            // 
            this.FileInfoEncrypted.Location = new System.Drawing.Point(26, 385);
            this.FileInfoEncrypted.Multiline = true;
            this.FileInfoEncrypted.Name = "FileInfoEncrypted";
            this.FileInfoEncrypted.ReadOnly = true;
            this.FileInfoEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileInfoEncrypted.Size = new System.Drawing.Size(456, 77);
            this.FileInfoEncrypted.TabIndex = 16;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(353, 217);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(105, 30);
            this.ExecuteButton.TabIndex = 17;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(23, 474);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 30);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CleanAllButton
            // 
            this.CleanAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanAllButton.Location = new System.Drawing.Point(376, 474);
            this.CleanAllButton.Name = "CleanAllButton";
            this.CleanAllButton.Size = new System.Drawing.Size(105, 30);
            this.CleanAllButton.TabIndex = 19;
            this.CleanAllButton.Text = "Очистить";
            this.CleanAllButton.UseVisualStyleBackColor = true;
            this.CleanAllButton.Click += new System.EventHandler(this.CleanAllButton_Click);
            // 
            // PrimitiveValue
            // 
            this.PrimitiveValue.FormattingEnabled = true;
            this.PrimitiveValue.Location = new System.Drawing.Point(25, 151);
            this.PrimitiveValue.Name = "PrimitiveValue";
            this.PrimitiveValue.Size = new System.Drawing.Size(141, 24);
            this.PrimitiveValue.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Первообразные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrimitiveValue);
            this.Controls.Add(this.CleanAllButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.FileInfoEncrypted);
            this.Controls.Add(this.FileInfoOrig);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalculateOpenKeyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OpenKey);
            this.Controls.Add(this.ValueK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValueX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileSelectionButton);
            this.Controls.Add(this.EncOrDec);
            this.Controls.Add(this.SelectedFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lb3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectedFile;
        private System.Windows.Forms.ComboBox EncOrDec;
        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueP;
        private System.Windows.Forms.TextBox ValueX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OpenKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateOpenKeyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FileInfoOrig;
        private System.Windows.Forms.TextBox FileInfoEncrypted;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CleanAllButton;
        private System.Windows.Forms.ComboBox PrimitiveValue;
        private System.Windows.Forms.Label label8;
    }
}

