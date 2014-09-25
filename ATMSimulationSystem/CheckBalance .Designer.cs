namespace ATMManager
{
    partial class CheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBalance));
            this.acount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b4 = new ATMManager.ButtonColorSet();
            this.b3 = new ATMManager.ButtonColorSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // acount
            // 
            this.acount.BackColor = System.Drawing.SystemColors.Menu;
            this.acount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acount.ForeColor = System.Drawing.Color.Red;
            this.acount.Location = new System.Drawing.Point(462, 97);
            this.acount.MaxLength = 18;
            this.acount.Name = "acount";
            this.acount.ReadOnly = true;
            this.acount.Size = new System.Drawing.Size(237, 26);
            this.acount.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(304, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Account Balance:";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardNum
            // 
            this.cardNum.AutoSize = true;
            this.cardNum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardNum.ForeColor = System.Drawing.Color.Red;
            this.cardNum.Location = new System.Drawing.Point(476, 62);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(223, 16);
            this.cardNum.TabIndex = 27;
            this.cardNum.Text = "Current Account Number：";
            this.cardNum.Click += new System.EventHandler(this.cardNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(476, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Current Account Number：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Details of your account";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.LightGray;
            this.b4.BorderColor = System.Drawing.Color.Blue;
            this.b4.Location = new System.Drawing.Point(566, 338);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(171, 36);
            this.b4.TabIndex = 25;
            this.b4.Text = "Cancel";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b4.Click += new System.EventHandler(this.buttons_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LightGray;
            this.b3.BorderColor = System.Drawing.Color.Blue;
            this.b3.Location = new System.Drawing.Point(390, 338);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(169, 36);
            this.b3.TabIndex = 24;
            this.b3.Text = "Return";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b3.Click += new System.EventHandler(this.buttons_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(45, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(654, 196);
            this.listBox1.TabIndex = 29;
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.acount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Balance";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.CheckBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acount;
        private System.Windows.Forms.Label label1;
        private ButtonColorSet b4;
        private ButtonColorSet b3;
        private System.Windows.Forms.Label cardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}