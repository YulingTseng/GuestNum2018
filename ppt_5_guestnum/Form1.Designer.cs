namespace ppt_5_guestnum
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessTxtBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ComfirmBtn = new System.Windows.Forms.Button();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MessageLabel.Location = new System.Drawing.Point(63, 68);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageLabel.Size = new System.Drawing.Size(280, 56);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "1<?<999";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "猜數字";
            // 
            // GuessTxtBox
            // 
            this.GuessTxtBox.Location = new System.Drawing.Point(176, 139);
            this.GuessTxtBox.Name = "GuessTxtBox";
            this.GuessTxtBox.Size = new System.Drawing.Size(139, 25);
            this.GuessTxtBox.TabIndex = 2;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(67, 212);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(67, 15);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "共猜了次";
            // 
            // ComfirmBtn
            // 
            this.ComfirmBtn.Location = new System.Drawing.Point(38, 292);
            this.ComfirmBtn.Name = "ComfirmBtn";
            this.ComfirmBtn.Size = new System.Drawing.Size(98, 30);
            this.ComfirmBtn.TabIndex = 4;
            this.ComfirmBtn.Text = "開始";
            this.ComfirmBtn.UseVisualStyleBackColor = true;
            this.ComfirmBtn.Click += new System.EventHandler(this.ComfirmBtn_Click);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.Location = new System.Drawing.Point(161, 292);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(98, 30);
            this.ReplayBtn.TabIndex = 5;
            this.ReplayBtn.Text = "暫停";
            this.ReplayBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(284, 292);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(98, 30);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "結束";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.ComfirmBtn);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.GuessTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessTxtBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ComfirmBtn;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

