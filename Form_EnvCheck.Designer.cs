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
            this.label_jdk_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_jdk
            // 
            resources.ApplyResources(this.Label_jdk, "Label_jdk");
            this.Label_jdk.Name = "Label_jdk";
            // 
            // label_jdk_status
            // 
            resources.ApplyResources(this.label_jdk_status, "label_jdk_status");
            this.label_jdk_status.Name = "label_jdk_status";
            // 
            // Form_EnvCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_jdk_status);
            this.Controls.Add(this.Label_jdk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EnvCheck";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_jdk;
        private System.Windows.Forms.Label label_jdk_status;
    }
}

