﻿namespace AutoVscJava
{
    partial class Form_EnvCheck
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EnvCheck));
            this.Label_jdk = new System.Windows.Forms.Label();
            this.Label_jdk_status = new System.Windows.Forms.Label();
            this.Button_install = new System.Windows.Forms.Button();
            this.Button_next = new System.Windows.Forms.Button();
            this.PictureBox_status = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_status)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_jdk
            // 
            resources.ApplyResources(this.Label_jdk, "Label_jdk");
            this.Label_jdk.Name = "Label_jdk";
            // 
            // Label_jdk_status
            // 
            resources.ApplyResources(this.Label_jdk_status, "Label_jdk_status");
            this.Label_jdk_status.Name = "Label_jdk_status";
            // 
            // Button_install
            // 
            resources.ApplyResources(this.Button_install, "Button_install");
            this.Button_install.Name = "Button_install";
            this.Button_install.UseVisualStyleBackColor = true;
            // 
            // Button_next
            // 
            resources.ApplyResources(this.Button_next, "Button_next");
            this.Button_next.Name = "Button_next";
            this.Button_next.UseVisualStyleBackColor = true;
            // 
            // PictureBox_status
            // 
            this.PictureBox_status.Image = global::AutoVscJava.Properties.Resources.loading_small;
            resources.ApplyResources(this.PictureBox_status, "PictureBox_status");
            this.PictureBox_status.Name = "PictureBox_status";
            this.PictureBox_status.TabStop = false;
            // 
            // Form_EnvCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Button_install);
            this.Controls.Add(this.PictureBox_status);
            this.Controls.Add(this.Label_jdk_status);
            this.Controls.Add(this.Label_jdk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EnvCheck";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form_EnvCheck_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_jdk;
        private System.Windows.Forms.Label Label_jdk_status;
        private System.Windows.Forms.PictureBox PictureBox_status;
        private System.Windows.Forms.Button Button_install;
        private System.Windows.Forms.Button Button_next;
    }
}

