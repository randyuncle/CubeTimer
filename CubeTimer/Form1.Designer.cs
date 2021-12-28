namespace CubeTimer
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
            this.components = new System.ComponentModel.Container();
            this.L_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scramble = new System.Windows.Forms.Label();
            this.B_guide = new System.Windows.Forms.Button();
            this.B_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_logo = new System.Windows.Forms.Button();
            this.B_logout = new System.Windows.Forms.Button();
            this.B_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_time.Location = new System.Drawing.Point(300, 192);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(479, 265);
            this.L_time.TabIndex = 0;
            this.L_time.Text = "0.00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // scramble
            // 
            this.scramble.AutoSize = true;
            this.scramble.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scramble.Location = new System.Drawing.Point(12, 9);
            this.scramble.Name = "scramble";
            this.scramble.Size = new System.Drawing.Size(0, 62);
            this.scramble.TabIndex = 1;
            // 
            // B_guide
            // 
            this.B_guide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_guide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_guide.Location = new System.Drawing.Point(1116, 9);
            this.B_guide.Name = "B_guide";
            this.B_guide.Size = new System.Drawing.Size(50, 50);
            this.B_guide.TabIndex = 2;
            this.B_guide.TabStop = false;
            this.B_guide.Text = "？";
            this.B_guide.UseVisualStyleBackColor = false;
            this.B_guide.Click += new System.EventHandler(this.B_guide_Click);
            // 
            // B_change
            // 
            this.B_change.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_change.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_change.Location = new System.Drawing.Point(1060, 9);
            this.B_change.Name = "B_change";
            this.B_change.Size = new System.Drawing.Size(50, 50);
            this.B_change.TabIndex = 3;
            this.B_change.TabStop = false;
            this.B_change.Text = "new";
            this.B_change.UseVisualStyleBackColor = false;
            this.B_change.Click += new System.EventHandler(this.B_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 4;
            // 
            // B_logo
            // 
            this.B_logo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_logo.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_logo.Location = new System.Drawing.Point(41, 635);
            this.B_logo.Name = "B_logo";
            this.B_logo.Size = new System.Drawing.Size(250, 100);
            this.B_logo.TabIndex = 5;
            this.B_logo.TabStop = false;
            this.B_logo.Text = "C#timer";
            this.B_logo.UseVisualStyleBackColor = false;
            this.B_logo.Click += new System.EventHandler(this.B_logo_Click);
            // 
            // B_logout
            // 
            this.B_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_logout.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_logout.Location = new System.Drawing.Point(41, 529);
            this.B_logout.Name = "B_logout";
            this.B_logout.Size = new System.Drawing.Size(120, 100);
            this.B_logout.TabIndex = 6;
            this.B_logout.TabStop = false;
            this.B_logout.Text = "登出";
            this.B_logout.UseVisualStyleBackColor = false;
            this.B_logout.Click += new System.EventHandler(this.B_logout_Click);
            // 
            // B_show
            // 
            this.B_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_show.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_show.Location = new System.Drawing.Point(171, 529);
            this.B_show.Name = "B_show";
            this.B_show.Size = new System.Drawing.Size(120, 100);
            this.B_show.TabIndex = 7;
            this.B_show.TabStop = false;
            this.B_show.Text = "隱藏";
            this.B_show.UseVisualStyleBackColor = false;
            this.B_show.Click += new System.EventHandler(this.B_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.B_show);
            this.Controls.Add(this.B_logout);
            this.Controls.Add(this.B_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_change);
            this.Controls.Add(this.B_guide);
            this.Controls.Add(this.scramble);
            this.Controls.Add(this.L_time);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scramble;
        private System.Windows.Forms.Button B_guide;
        private System.Windows.Forms.Button B_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_logo;
        private System.Windows.Forms.Button B_logout;
        private System.Windows.Forms.Button B_show;
    }
}

