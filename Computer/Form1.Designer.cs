namespace Computer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.LessButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(33, 282);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(105, 39);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.button_click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(199, 192);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(49, 39);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.operator_click);
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(144, 282);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(49, 39);
            this.DotButton.TabIndex = 0;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.button_click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(35, 237);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(49, 39);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.button_click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(144, 192);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(49, 39);
            this.SixButton.TabIndex = 0;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.button_click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(90, 237);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(49, 39);
            this.TwoButton.TabIndex = 0;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.button_click);
            // 
            // LessButton
            // 
            this.LessButton.Location = new System.Drawing.Point(199, 147);
            this.LessButton.Name = "LessButton";
            this.LessButton.Size = new System.Drawing.Size(49, 39);
            this.LessButton.TabIndex = 0;
            this.LessButton.Text = "-";
            this.LessButton.UseVisualStyleBackColor = true;
            this.LessButton.Click += new System.EventHandler(this.operator_click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(35, 192);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(49, 39);
            this.FourButton.TabIndex = 0;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.button_click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(90, 192);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(48, 39);
            this.FiveButton.TabIndex = 0;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.button_click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(35, 147);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(49, 39);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.button_click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(144, 237);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(49, 39);
            this.ThreeButton.TabIndex = 0;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.button_click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(90, 147);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(48, 39);
            this.EightButton.TabIndex = 0;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.button_click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(144, 147);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(49, 39);
            this.NineButton.TabIndex = 0;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.button_click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(35, 102);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(49, 39);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "←";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(144, 102);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(49, 39);
            this.DivisionButton.TabIndex = 0;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.operator_click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(199, 237);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(49, 84);
            this.EqualButton.TabIndex = 0;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(199, 102);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(49, 39);
            this.MultiplyButton.TabIndex = 2;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.operator_click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(90, 102);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(48, 39);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(35, 58);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(213, 30);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.Location = new System.Drawing.Point(35, 28);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(213, 30);
            this.equation.TabIndex = 4;
            this.equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 337);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LessButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.ZeroButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button LessButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label equation;
    }
}

