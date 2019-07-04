namespace AutoVscJava
{
    partial class Form_InstallJdk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_status = new System.Windows.Forms.Label();
            this.ProgressBar_process = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Label_status
            // 
            this.Label_status.AutoSize = true;
            this.Label_status.Location = new System.Drawing.Point(188, 9);
            this.Label_status.Name = "Label_status";
            this.Label_status.Size = new System.Drawing.Size(41, 12);
            this.Label_status.TabIndex = 0;
            this.Label_status.Text = "初始化";
            this.Label_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProgressBar_process
            // 
            this.ProgressBar_process.Location = new System.Drawing.Point(12, 24);
            this.ProgressBar_process.Name = "ProgressBar_process";
            this.ProgressBar_process.Size = new System.Drawing.Size(396, 25);
            this.ProgressBar_process.TabIndex = 1;
            // 
            // Form_InstallJdk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 60);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBar_process);
            this.Controls.Add(this.Label_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_InstallJdk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "正在安装Java SE";
            this.Load += new System.EventHandler(this.Form_InstallJdk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_status;
        private System.Windows.Forms.ProgressBar ProgressBar_process;
    }
}