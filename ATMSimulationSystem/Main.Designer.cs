namespace ATMManager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonColorSet2 = new ATMManager.ButtonColorSet();
            this.buttonColorSet1 = new ATMManager.ButtonColorSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ATMManager.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 386);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonColorSet2
            // 
            this.buttonColorSet2.BackColor = System.Drawing.Color.LightGray;
            this.buttonColorSet2.BorderColor = System.Drawing.Color.Blue;
            this.buttonColorSet2.Location = new System.Drawing.Point(610, 322);
            this.buttonColorSet2.Name = "buttonColorSet2";
            this.buttonColorSet2.Size = new System.Drawing.Size(114, 36);
            this.buttonColorSet2.TabIndex = 2;
            this.buttonColorSet2.Text = "QUIT";
            this.buttonColorSet2.UseVisualStyleBackColor = false;
            this.buttonColorSet2.UseWaitCursor = true;
            this.buttonColorSet2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonColorSet2.Click += new System.EventHandler(this.buttonColorSet2_Click);
            this.buttonColorSet2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // buttonColorSet1
            // 
            this.buttonColorSet1.BackColor = System.Drawing.Color.LightGray;
            this.buttonColorSet1.BorderColor = System.Drawing.Color.Blue;
            this.buttonColorSet1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonColorSet1.Location = new System.Drawing.Point(394, 322);
            this.buttonColorSet1.Name = "buttonColorSet1";
            this.buttonColorSet1.Size = new System.Drawing.Size(204, 36);
            this.buttonColorSet1.TabIndex = 1;
            this.buttonColorSet1.Text = "Insert card";
            this.buttonColorSet1.UseVisualStyleBackColor = false;
            this.buttonColorSet1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonColorSet1.Click += new System.EventHandler(this.buttonColorSet1_Click);
            this.buttonColorSet1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.ControlBox = false;
            this.Controls.Add(this.buttonColorSet2);
            this.Controls.Add(this.buttonColorSet1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank ATM System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonColorSet buttonColorSet1;
        private ButtonColorSet buttonColorSet2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}