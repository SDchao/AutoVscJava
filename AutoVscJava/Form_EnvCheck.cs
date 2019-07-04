using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AutoVscJava.Classes;
using AutoVscJava.Properties;

namespace AutoVscJava
{
    public partial class Form_EnvCheck : Form
    {
        public Form_EnvCheck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task checkJdkTask = new Task(() =>
            {
                if (EnvChecker.CheckJavaSE())
                {
                    Label_jdk_status.Text = "已安装";
                    Label_jdk_status.ForeColor = Color.Green;
                    PictureBox_status.Image = Resources.complete;
                    Button_next.Enabled = true;
                }
                else
                {
                    Label_jdk_status.Text = "未安装";
                    Label_jdk_status.ForeColor = Color.Red;
                    PictureBox_status.Image = Resources.error;
                    Button_install.Show();
                }
            });
            checkJdkTask.Start();
        }

        private void Form_EnvCheck_Shown(object sender, EventArgs e)
        {
            Button_install.Hide();
        }

        private async void Button_install_Click(object sender, EventArgs e)
        {
            Button_install.Enabled = false;
            PictureBox_status.Image = Resources.loading_small;
            Label_jdk_status.Text = "正在安装";
            Label_jdk_status.ForeColor = Color.Black;

            string targetPath;
            while (true)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog
                {
                    Description = "请选择Java SE的安装文件夹"
                };

                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    targetPath = dialog.SelectedPath;
                    break;
                }
            }

            var r = Task.Run(() =>
            {
                return JdkInstaller.Install(targetPath);
            });

            InstallCompleted(await r);
        }

        public void InstallCompleted(bool result)
        {
            if (result)
            {
                Label_jdk_status.Text = "已安装";
                Label_jdk_status.ForeColor = Color.Green;
                PictureBox_status.Image = Resources.complete;
                Button_next.Enabled = true;
                Button_install.Hide();
            }
            else
            {
                Label_jdk_status.Text = "未安装";
                Label_jdk_status.ForeColor = Color.Red;
                PictureBox_status.Image = Resources.error;
                Button_install.Show();
            }
        }

        private void Button_next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label_copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/12263994");
        }
    }
}
