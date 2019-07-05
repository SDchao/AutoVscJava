namespace AutoVscJava
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
            this.Button_jdk_install = new System.Windows.Forms.Button();
            this.Button_next = new System.Windows.Forms.Button();
            this.PictureBox_jdk_status = new System.Windows.Forms.PictureBox();
            this.Label_copyright = new System.Windows.Forms.Label();
            this.Label_vsc = new System.Windows.Forms.Label();
            this.Label_vsc_status = new System.Windows.Forms.Label();
            this.PictureBox_vsc_status = new System.Windows.Forms.PictureBox();
            this.Button_vsc_install = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_jdk_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_vsc_status)).BeginInit();
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
            // Button_jdk_install
            // 
            resources.ApplyResources(this.Button_jdk_install, "Button_jdk_install");
            this.Button_jdk_install.Name = "Button_jdk_install";
            this.Button_jdk_install.UseVisualStyleBackColor = true;
            this.Button_jdk_install.Click += new System.EventHandler(this.Button_install_Click);
            // 
            // Button_next
            // 
            resources.ApplyResources(this.Button_next, "Button_next");
            this.Button_next.Name = "Button_next";
            this.Button_next.UseVisualStyleBackColor = true;
            this.Button_next.Click += new System.EventHandler(this.Button_next_Click);
            // 
            // PictureBox_jdk_status
            // 
            this.PictureBox_jdk_status.Image = global::AutoVscJava.Properties.Resources.loading_small;
            resources.ApplyResources(this.PictureBox_jdk_status, "PictureBox_jdk_status");
            this.PictureBox_jdk_status.Name = "PictureBox_jdk_status";
            this.PictureBox_jdk_status.TabStop = false;
            // 
            // Label_copyright
            // 
            resources.ApplyResources(this.Label_copyright, "Label_copyright");
            this.Label_copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_copyright.Name = "Label_copyright";
            this.Label_copyright.Click += new System.EventHandler(this.Label_copyright_Click);
            // 
            // Label_vsc
            // 
            resources.ApplyResources(this.Label_vsc, "Label_vsc");
            this.Label_vsc.Name = "Label_vsc";
            // 
            // Label_vsc_status
            // 
            resources.ApplyResources(this.Label_vsc_status, "Label_vsc_status");
            this.Label_vsc_status.Name = "Label_vsc_status";
            // 
            // PictureBox_vsc_status
            // 
            this.PictureBox_vsc_status.Image = global::AutoVscJava.Properties.Resources.loading_small;
            resources.ApplyResources(this.PictureBox_vsc_status, "PictureBox_vsc_status");
            this.PictureBox_vsc_status.Name = "PictureBox_vsc_status";
            this.PictureBox_vsc_status.TabStop = false;
            // 
            // Button_vsc_install
            // 
            resources.ApplyResources(this.Button_vsc_install, "Button_vsc_install");
            this.Button_vsc_install.Name = "Button_vsc_install";
            this.Button_vsc_install.UseVisualStyleBackColor = true;
            this.Button_vsc_install.Click += new System.EventHandler(this.Button_vsc_install_Click);
            // 
            // Form_EnvCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_vsc_install);
            this.Controls.Add(this.PictureBox_vsc_status);
            this.Controls.Add(this.Label_vsc_status);
            this.Controls.Add(this.Label_vsc);
            this.Controls.Add(this.Label_copyright);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Button_jdk_install);
            this.Controls.Add(this.PictureBox_jdk_status);
            this.Controls.Add(this.Label_jdk_status);
            this.Controls.Add(this.Label_jdk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EnvCheck";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form_EnvCheck_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_jdk_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_vsc_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_jdk;
        private System.Windows.Forms.Label Label_jdk_status;
        private System.Windows.Forms.PictureBox PictureBox_jdk_status;
        private System.Windows.Forms.Button Button_jdk_install;
        private System.Windows.Forms.Button Button_next;
        private System.Windows.Forms.Label Label_copyright;
        private System.Windows.Forms.Label Label_vsc;
        private System.Windows.Forms.Label Label_vsc_status;
        private System.Windows.Forms.PictureBox PictureBox_vsc_status;
        private System.Windows.Forms.Button Button_vsc_install;
    }
}

