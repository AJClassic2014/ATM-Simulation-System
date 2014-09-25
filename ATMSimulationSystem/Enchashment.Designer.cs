namespace ATMManager
{
    partial class Enchashment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enchashment));
            this.acount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyBoard1 = new ATMManager.KeyBoard1();
            this.b6 = new ATMManager.ButtonColorSet();
            this.b5 = new ATMManager.ButtonColorSet();
            this.b4 = new ATMManager.ButtonColorSet();
            this.b3 = new ATMManager.ButtonColorSet();
            this.b2 = new ATMManager.ButtonColorSet();
            this.b1 = new ATMManager.ButtonColorSet();
            this.SuspendLayout();
            // 
            // acount
            // 
            this.acount.Location = new System.Drawing.Point(259, 149);
            this.acount.MaxLength = 18;
            this.acount.Name = "acount";
            this.acount.Size = new System.Drawing.Size(237, 21);
            this.acount.TabIndex = 6;
            this.acount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acount_KeyPress);
            this.acount.Enter += new System.EventHandler(this.acount_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(167, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Withdraw";
            // 
            // cardNum
            // 
            this.cardNum.AllowDrop = true;
            this.cardNum.AutoSize = true;
            this.cardNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardNum.ForeColor = System.Drawing.Color.Red;
            this.cardNum.Location = new System.Drawing.Point(314, 111);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(136, 16);
            this.cardNum.TabIndex = 14;
            this.cardNum.Text = "Account Number：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(167, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Account Number：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(316, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Account Balance：";
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBoard1.Location = new System.Drawing.Point(208, 190);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(288, 166);
            this.keyBoard1.TabIndex = 37;
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.LightGray;
            this.b6.BorderColor = System.Drawing.Color.Blue;
            this.b6.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b6.Location = new System.Drawing.Point(565, 306);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(171, 36);
            this.b6.TabIndex = 12;
            this.b6.Text = "Cancel";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b6.Click += new System.EventHandler(this.buttons_Click);
            this.b6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.LightGray;
            this.b5.BorderColor = System.Drawing.Color.Blue;
            this.b5.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b5.Location = new System.Drawing.Point(565, 207);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(171, 36);
            this.b5.TabIndex = 11;
            this.b5.Text = "Confirm";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b5.Click += new System.EventHandler(this.buttons_Click);
            this.b5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.LightGray;
            this.b4.BorderColor = System.Drawing.Color.Blue;
            this.b4.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b4.Location = new System.Drawing.Point(565, 256);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(171, 36);
            this.b4.TabIndex = 10;
            this.b4.Text = "Return";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b4.Click += new System.EventHandler(this.buttons_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LightGray;
            this.b3.BorderColor = System.Drawing.Color.Blue;
            this.b3.Location = new System.Drawing.Point(9, 306);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(169, 36);
            this.b3.TabIndex = 9;
            this.b3.Text = "５００";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b3.Click += new System.EventHandler(this.buttons_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.LightGray;
            this.b2.BorderColor = System.Drawing.Color.Blue;
            this.b2.Location = new System.Drawing.Point(10, 256);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(169, 36);
            this.b2.TabIndex = 8;
            this.b2.Text = "２００";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b2.Click += new System.EventHandler(this.buttons_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LightGray;
            this.b1.BorderColor = System.Drawing.Color.Blue;
            this.b1.Location = new System.Drawing.Point(12, 207);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(169, 36);
            this.b1.TabIndex = 7;
            this.b1.Text = "１００";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b1.Click += new System.EventHandler(this.buttons_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // Enchashment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.acount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enchashment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Enchashment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acount;
        private System.Windows.Forms.Label label1;
        private ButtonColorSet b3;
        private ButtonColorSet b2;
        private ButtonColorSet b1;
        private ButtonColorSet b6;
        private ButtonColorSet b5;
        private ButtonColorSet b4;
        private System.Windows.Forms.Label cardNum;
        private System.Windows.Forms.Label label2;
        private KeyBoard1 keyBoard1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}