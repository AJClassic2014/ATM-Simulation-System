namespace ATMManager
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keyBoard1 = new ATMManager.KeyBoard1();
            this.b2 = new ATMManager.ButtonColorSet();
            this.b1 = new ATMManager.ButtonColorSet();
            this.b4 = new ATMManager.ButtonColorSet();
            this.b3 = new ATMManager.ButtonColorSet();
            this.SuspendLayout();
            // 
            // old
            // 
            this.old.Location = new System.Drawing.Point(267, 73);
            this.old.MaxLength = 6;
            this.old.Name = "old";
            this.old.PasswordChar = '*';
            this.old.Size = new System.Drawing.Size(237, 21);
            this.old.TabIndex = 25;
            this.old.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new2_KeyPress);
            this.old.Enter += new System.EventHandler(this.new2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(117, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Old Password:";
            // 
            // new1
            // 
            this.new1.Location = new System.Drawing.Point(267, 106);
            this.new1.MaxLength = 6;
            this.new1.Name = "new1";
            this.new1.PasswordChar = '*';
            this.new1.Size = new System.Drawing.Size(237, 21);
            this.new1.TabIndex = 27;
            this.new1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new2_KeyPress);
            this.new1.Enter += new System.EventHandler(this.new2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(117, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "New Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // new2
            // 
            this.new2.Location = new System.Drawing.Point(267, 149);
            this.new2.MaxLength = 6;
            this.new2.Name = "new2";
            this.new2.PasswordChar = '*';
            this.new2.Size = new System.Drawing.Size(237, 21);
            this.new2.TabIndex = 29;
            this.new2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new2_KeyPress);
            this.new2.Enter += new System.EventHandler(this.new2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(117, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Confirm:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cardNum
            // 
            this.cardNum.AutoSize = true;
            this.cardNum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardNum.ForeColor = System.Drawing.Color.Red;
            this.cardNum.Location = new System.Drawing.Point(305, 38);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(151, 16);
            this.cardNum.TabIndex = 35;
            this.cardNum.Text = "Account Number：";
            this.cardNum.Click += new System.EventHandler(this.cardNum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(117, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Account Number：";
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBoard1.Location = new System.Drawing.Point(234, 180);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(299, 194);
            this.keyBoard1.TabIndex = 36;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.LightGray;
            this.b2.BorderColor = System.Drawing.Color.Blue;
            this.b2.Location = new System.Drawing.Point(16, 312);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(171, 36);
            this.b2.TabIndex = 33;
            this.b2.Text = "Change Password";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b2.Click += new System.EventHandler(this.b3_Click);
            this.b2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LightGray;
            this.b1.BorderColor = System.Drawing.Color.Blue;
            this.b1.Location = new System.Drawing.Point(16, 258);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(171, 36);
            this.b1.TabIndex = 32;
            this.b1.Text = "Clear";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b1.Click += new System.EventHandler(this.b3_Click);
            this.b1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.LightGray;
            this.b4.BorderColor = System.Drawing.Color.Blue;
            this.b4.Location = new System.Drawing.Point(566, 312);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(169, 36);
            this.b4.TabIndex = 31;
            this.b4.Text = "Cancel";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b4.Click += new System.EventHandler(this.b3_Click);
            this.b4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.LightGray;
            this.b3.BorderColor = System.Drawing.Color.Blue;
            this.b3.Location = new System.Drawing.Point(566, 258);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(169, 36);
            this.b3.TabIndex = 30;
            this.b3.Text = "Return";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.new2);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.old);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox new1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new2;
        private System.Windows.Forms.Label label4;
        private ButtonColorSet b4;
        private ButtonColorSet b3;
        private ButtonColorSet b2;
        private ButtonColorSet b1;
        private System.Windows.Forms.Label cardNum;
        private System.Windows.Forms.Label label5;
        private KeyBoard1 keyBoard1;
    }
}