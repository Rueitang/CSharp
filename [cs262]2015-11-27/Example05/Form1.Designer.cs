namespace Example05
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
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.numberTextBox3 = new System.Windows.Forms.TextBox();
            this.OpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.OpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox1.Location = new System.Drawing.Point(99, 102);
            this.numberTextBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(195, 38);
            this.numberTextBox1.TabIndex = 0;
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox2.Location = new System.Drawing.Point(348, 102);
            this.numberTextBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(195, 38);
            this.numberTextBox2.TabIndex = 0;
            // 
            // numberTextBox3
            // 
            this.numberTextBox3.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox3.Location = new System.Drawing.Point(597, 102);
            this.numberTextBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numberTextBox3.Name = "numberTextBox3";
            this.numberTextBox3.Size = new System.Drawing.Size(195, 38);
            this.numberTextBox3.TabIndex = 0;
            // 
            // OpLabel
            // 
            this.OpLabel.AutoSize = true;
            this.OpLabel.Font = new System.Drawing.Font("新細明體", 19F);
            this.OpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpLabel.Location = new System.Drawing.Point(308, 114);
            this.OpLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OpLabel.Name = "OpLabel";
            this.OpLabel.Size = new System.Drawing.Size(26, 26);
            this.OpLabel.TabIndex = 1;
            this.OpLabel.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 19F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(557, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddButton.Location = new System.Drawing.Point(99, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(228, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "減";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MulButton
            // 
            this.MulButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MulButton.Location = new System.Drawing.Point(358, 191);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(96, 39);
            this.MulButton.TabIndex = 2;
            this.MulButton.Text = "乘";
            this.MulButton.UseVisualStyleBackColor = true;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DivButton.Location = new System.Drawing.Point(487, 191);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(96, 39);
            this.DivButton.TabIndex = 2;
            this.DivButton.Text = "除";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // OpButton
            // 
            this.OpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpButton.Location = new System.Drawing.Point(99, 270);
            this.OpButton.Name = "OpButton";
            this.OpButton.Size = new System.Drawing.Size(225, 39);
            this.OpButton.TabIndex = 2;
            this.OpButton.Text = "答案";
            this.OpButton.UseVisualStyleBackColor = true;
            this.OpButton.Click += new System.EventHandler(this.OpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OpButton;
            this.ClientSize = new System.Drawing.Size(892, 373);
            this.Controls.Add(this.OpButton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpLabel);
            this.Controls.Add(this.numberTextBox3);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.numberTextBox1);
            this.Font = new System.Drawing.Font("新細明體", 19F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.TextBox numberTextBox3;
        private System.Windows.Forms.Label OpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button OpButton;
    }
}

