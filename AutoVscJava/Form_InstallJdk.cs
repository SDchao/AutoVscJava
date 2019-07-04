using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SevenZip;

namespace AutoVscJava
{
    public partial class Form_InstallJdk : Form
    {
        private delegate string SelectPathDelegate();
        public Form_InstallJdk()
        {
            InitializeComponent();
        }

        private void Form_InstallJdk_Load(object sender, EventArgs e)
        {
            Thread installTask = new Thread(StartInstall);
            installTask.Start();
        }

        private void StartInstall()
        {
            if(!File.Exists("jdk.7z"))
            {
                MessageBox.Show("没有找到目录下的jdk.7z！\n请阅读下载页的使用说明", "缺失安装文件");
                DialogResult = DialogResult.Abort;
                Close();
            }

            string path = (string)this.Invoke(new SelectPathDelegate(SelectPath));
            
            
        }

        private string SelectPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Java SE的安装路径";
            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.SelectedPath;
            else
                return "";
        }
    }
}
