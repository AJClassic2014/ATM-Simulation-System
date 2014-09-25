namespace ATMManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.cardNum = new System.Windows.Forms.ComboBox();
            this.keyBoard1 = new ATMManager.KeyBoard1();
            this.buttonColorSet5 = new ATMManager.ButtonColorSet();
            this.buttonColorSet4 = new ATMManager.ButtonColorSet();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(231, 131);
            this.password.MaxLength = 6;
            this.password.Name = "password";
            this.password.PasswordChar = '＊';
            this.password.Size = new System.Drawing.Size(259, 21);
            this.password.TabIndex = 3;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // cardNum
            // 
            this.cardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardNum.FormattingEnabled = true;
            this.cardNum.Location = new System.Drawing.Point(231, 64);
            this.cardNum.Name = "cardNum";
            this.cardNum.Size = new System.Drawing.Size(259, 20);
            this.cardNum.TabIndex = 7;
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.keyBoard1.Location = new System.Drawing.Point(213, 180);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(299, 194);
            this.keyBoard1.TabIndex = 37;
            // 
            // buttonColorSet5
            // 
            this.buttonColorSet5.BackColor = System.Drawing.Color.LightGray;
            this.buttonColorSet5.BorderColor = System.Drawing.Color.Blue;
            this.buttonColorSet5.Location = new System.Drawing.Point(577, 243);
            this.buttonColorSet5.Name = "buttonColorSet5";
            this.buttonColorSet5.Size = new System.Drawing.Size(155, 36);
            this.buttonColorSet5.TabIndex = 6;
            this.buttonColorSet5.Text = "Confirm";
            this.buttonColorSet5.UseVisualStyleBackColor = false;
            this.buttonColorSet5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonColorSet5.Click += new System.EventHandler(this.buttonColorSet5_Click);
            this.buttonColorSet5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // buttonColorSet4
            // 
            this.buttonColorSet4.BackColor = System.Drawing.Color.LightGray;
            this.buttonColorSet4.BorderColor = System.Drawing.Color.Blue;
            this.buttonColorSet4.Location = new System.Drawing.Point(579, 295);
            this.buttonColorSet4.Name = "buttonColorSet4";
            this.buttonColorSet4.Size = new System.Drawing.Size(155, 36);
            this.buttonColorSet4.TabIndex = 5;
            this.buttonColorSet4.Text = "Cancel";
            this.buttonColorSet4.UseVisualStyleBackColor = false;
            this.buttonColorSet4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonColorSet4.Click += new System.EventHandler(this.buttonColorSet4_Click);
            this.buttonColorSet4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.password);
            this.Controls.Add(this.keyBoard1);
            this.Controls.Add(this.cardNum);
            this.Controls.Add(this.buttonColorSet5);
            this.Controls.Add(this.buttonColorSet4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log in ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private ButtonColorSet buttonColorSet5;
        private ButtonColorSet buttonColorSet4;
        private System.Windows.Forms.ComboBox cardNum;
        private KeyBoard1 keyBoard1;
    }
}