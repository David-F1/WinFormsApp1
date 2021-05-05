
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbTime = new System.Windows.Forms.Label();
            this.LbSecond = new System.Windows.Forms.Label();
            this.LbDay = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTime.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LbTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbTime.Location = new System.Drawing.Point(34, 35);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(249, 95);
            this.LbTime.TabIndex = 0;
            this.LbTime.Text = "22:30\r\n";
            this.LbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbSecond
            // 
            this.LbSecond.AutoSize = true;
            this.LbSecond.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSecond.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbSecond.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbSecond.Location = new System.Drawing.Point(287, 84);
            this.LbSecond.Name = "LbSecond";
            this.LbSecond.Size = new System.Drawing.Size(53, 36);
            this.LbSecond.TabIndex = 1;
            this.LbSecond.Text = "22";
            // 
            // LbDay
            // 
            this.LbDay.AutoSize = true;
            this.LbDay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbDay.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LbDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbDay.Location = new System.Drawing.Point(390, 210);
            this.LbDay.Name = "LbDay";
            this.LbDay.Size = new System.Drawing.Size(164, 47);
            this.LbDay.TabIndex = 2;
            this.LbDay.Text = "Sunday";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbDate.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LbDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbDate.Location = new System.Drawing.Point(24, 197);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(342, 63);
            this.LbDate.TabIndex = 3;
            this.LbDate.Text = "April 11 2021";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(645, 284);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.LbDay);
            this.Controls.Add(this.LbSecond);
            this.Controls.Add(this.LbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbSecond;
        private System.Windows.Forms.Label LbDay;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Timer timer;
    }
}

