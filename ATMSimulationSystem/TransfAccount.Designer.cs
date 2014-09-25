namespace ATMManager
{
    partial class TransfAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransfAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.acount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.ComboBox();
            this.keyBoard1 = new ATMManager.KeyBoard1();
            this.b1 = new ATMManager.ButtonColorSet();
            this.b4 = new ATMManager.ButtonColorSet();
            this.b2 = new ATMManager.ButtonColorSet();
            this.b3 = new ATMManager.ButtonColorSet();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Card Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // acount
            // 
            this.acount.Location = new System.Drawing.Point(264, 164);
            this.acount.MaxLength = 18;
            this.acount.Name = "acount";
            this.acount.Size = new System.Drawing.Size(237, 21);
            this.acount.TabIndex = 19;
            this.acount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acount_KeyPress);
            this.acount.Enter += new System.EventHandler(this.acount_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(147, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(304, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Account Number：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(147, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Account Number：";
            // 
            // cardNum
            // 
            this.cardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardNum.FormattingEnabled = true;
            this.cardNum.Location = new System.Drawing.Point(264, 120);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(237, 20);
            this.cardNum.TabIndex = 23;
            this.cardNum.SelectedIndexChanged += new System.EventHandler(this.cardNum_SelectedIndexChanged);
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBoard1.Location = new System.Drawing.Point(238, 212);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(288, 162);
            this.keyBoard1.TabIndex = 37;
            this.keyBoard1.Load += new System.EventHandler(this.keyBoard1_Load);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LightGray;
            this.b1.BorderColor = System.Drawing.Color.Blue;
            this.b1.Location = new System.Drawing.Point(15, 254);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(169, 36);
            this.b1.TabIndex = 20;
            this.b1.Text = "Clear";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b1.Click += new System.EventHandler(this.buttons_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.LightGray;
            this.b4.BorderColor = System.Drawing.Color.Blue;
            this.b4.Location = new System.Drawing.Point(567, 307);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(171, 36);
            this.b4.TabIndex = 15;
            this.b4.Text = "Cancel";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b4.Click += new System.EventHandler(this.buttons_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.LightGray;
            this.b2.BorderColor = System.Drawing.Color.Blue;
            this.b2.Location = new System.Drawing.Point(15, 307);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(169, 36);
            this.b2.TabIndex = 14;
            this.b2.Text = "Confirm";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b2.Click += new System.EventHandler(this.buttons_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LightGray;
            this.b3.BorderColor = System.Drawing.Color.Blue;
            this.b3.Location = new System.Drawing.Point(569, 254);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(169, 36);
            this.b3.TabIndex = 13;
            this.b3.Text = "Return";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b3.Click += new System.EventHandler(this.buttons_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // TransfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.acount);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transfer";
            this.Load += new System.EventHandler(this.TransfAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonColorSet b4;
        private ButtonColorSet b2;
        private ButtonColorSet b3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acount;
        private System.Windows.Forms.Label label2;
        private ButtonColorSet b1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cardNum;
        private KeyBoard1 keyBoard1;
    }
}