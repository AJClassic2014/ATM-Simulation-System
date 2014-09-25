namespace ATMManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.Label();
            this.b6 = new ATMManager.ButtonColorSet();
            this.b4 = new ATMManager.ButtonColorSet();
            this.b3 = new ATMManager.ButtonColorSet();
            this.b2 = new ATMManager.ButtonColorSet();
            this.b1 = new ATMManager.ButtonColorSet();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Number：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardNum
            // 
            this.cardNum.AutoSize = true;
            this.cardNum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardNum.ForeColor = System.Drawing.Color.Red;
            this.cardNum.Location = new System.Drawing.Point(293, 96);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(151, 16);
            this.cardNum.TabIndex = 7;
            this.cardNum.Text = "Account Number：";
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.LightGray;
            this.b6.BorderColor = System.Drawing.Color.Blue;
            this.b6.Location = new System.Drawing.Point(545, 308);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(190, 36);
            this.b6.TabIndex = 5;
            this.b6.Text = "Cancel";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b6.Click += new System.EventHandler(this.buttons_Click);
            this.b6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.LightGray;
            this.b4.BorderColor = System.Drawing.Color.Blue;
            this.b4.Location = new System.Drawing.Point(545, 259);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(190, 36);
            this.b4.TabIndex = 3;
            this.b4.Text = "Withdraw";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b4.Click += new System.EventHandler(this.buttons_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LightGray;
            this.b3.BorderColor = System.Drawing.Color.Blue;
            this.b3.Location = new System.Drawing.Point(13, 308);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(204, 36);
            this.b3.TabIndex = 2;
            this.b3.Text = "Change Password";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b3.Click += new System.EventHandler(this.buttons_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.LightGray;
            this.b2.BorderColor = System.Drawing.Color.Blue;
            this.b2.Location = new System.Drawing.Point(14, 259);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(204, 36);
            this.b2.TabIndex = 1;
            this.b2.Text = "Check Balance";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b2.Click += new System.EventHandler(this.buttons_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LightGray;
            this.b1.BorderColor = System.Drawing.Color.Blue;
            this.b1.Location = new System.Drawing.Point(14, 207);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(204, 36);
            this.b1.TabIndex = 0;
            this.b1.Text = "Transfer";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b1.Click += new System.EventHandler(this.buttons_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM system";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonColorSet b1;
        private ButtonColorSet b2;
        private ButtonColorSet b3;
        private ButtonColorSet b4;
        private ButtonColorSet b6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardNum;
    }
}

