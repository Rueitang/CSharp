namespace Example03
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.numberTextBox3 = new System.Windows.Forms.TextBox();
            this.Addlabel = new System.Windows.Forms.Label();
            this.Equallabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("新細明體", 19F);
            this.calculateButton.Location = new System.Drawing.Point(44, 107);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(250, 55);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox1.Location = new System.Drawing.Point(44, 29);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(100, 38);
            this.numberTextBox1.TabIndex = 1;
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox2.Location = new System.Drawing.Point(224, 29);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(100, 38);
            this.numberTextBox2.TabIndex = 1;
            // 
            // numberTextBox3
            // 
            this.numberTextBox3.Font = new System.Drawing.Font("新細明體", 19F);
            this.numberTextBox3.Location = new System.Drawing.Point(403, 29);
            this.numberTextBox3.Name = "numberTextBox3";
            this.numberTextBox3.Size = new System.Drawing.Size(100, 38);
            this.numberTextBox3.TabIndex = 1;
            // 
            // Addlabel
            // 
            this.Addlabel.AutoSize = true;
            this.Addlabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.Addlabel.Location = new System.Drawing.Point(170, 33);
            this.Addlabel.Name = "Addlabel";
            this.Addlabel.Size = new System.Drawing.Size(23, 24);
            this.Addlabel.TabIndex = 2;
            this.Addlabel.Text = "+";
            // 
            // Equallabel
            // 
            this.Equallabel.AutoSize = true;
            this.Equallabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.Equallabel.Location = new System.Drawing.Point(350, 33);
            this.Equallabel.Name = "Equallabel";
            this.Equallabel.Size = new System.Drawing.Size(23, 24);
            this.Equallabel.TabIndex = 2;
            this.Equallabel.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 280);
            this.Controls.Add(this.Equallabel);
            this.Controls.Add(this.Addlabel);
            this.Controls.Add(this.numberTextBox3);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.numberTextBox1);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.TextBox numberTextBox3;
        private System.Windows.Forms.Label Addlabel;
        private System.Windows.Forms.Label Equallabel;
    }
}

