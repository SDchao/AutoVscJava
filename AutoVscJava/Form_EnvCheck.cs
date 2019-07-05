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
        private static int jdkEnv = 0;
        private static int vscEnv = 0;

        public Form_EnvCheck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            //检查jdk
            Task checkJdkTask = new Task(() =>
            {
                if (EnvChecker.CheckJavaSE())
                {
                    jdkEnv = 1;
                    Label_jdk_status.Text = "已安装";
                    Label_jdk_status.ForeColor = Color.Green;
                    PictureBox_jdk_status.Image = Resources.complete;
                    InstallCompleted();
                }
                else
                {
                    Label_jdk_status.Text = "未安装";
                    Label_jdk_status.ForeColor = Color.Red;
                    PictureBox_jdk_status.Image = Resources.error;
                    Button_jdk_install.Show();
                }
            });
            checkJdkTask.Start();
            //检查VScode
            Task checkVscTask = new Task(() =>
            {
                if(EnvChecker.CheckVscode())
                {
                    Label_vsc_status.Text = "正在检查插件";
                    if(EnvChecker.CheckVscExtension())
                    {
                        vscEnv = 1;
                        Label_vsc_status.Text = "已完成";
                        Label_vsc_status.ForeColor = Color.Green;
                        PictureBox_vsc_status.Image = Resources.complete;
                    }
                    else
                    {
                        Label_vsc_status.Text = "未安装插件";
                        Label_vsc_status.ForeColor = Color.Green;
                        PictureBox_vsc_status.Image = Resources.error;
                        Button_vsc_install.Show();
                    }
                }
                else
                {
                    vscEnv = -1;
                    Label_vsc_status.Text = "未安装VScode";
                    PictureBox_vsc_status.Image = Resources.complete;
                    InstallCompleted();
                }
            });
            checkVscTask.Start();
        }

        private async void Button_install_Click(object sender, EventArgs e)
        {
            //设置窗口资源
            Button_jdk_install.Enabled = false;
            PictureBox_jdk_status.Image = Resources.loading_small;
            Label_jdk_status.Text = "正在安装";
            Label_jdk_status.ForeColor = Color.Black;

            //选择安装路径
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

            //异步调用安装
            var r = Task.Run(() =>
            {
                return JdkInstaller.Install(targetPath);
            });

            InstallJDKCompleted(await r);
        }

        private void Button_vsc_install_Click(object sender, EventArgs e)
        {

        }

        public void InstallJDKCompleted(bool result)
        {
            if (result)
            {
                jdkEnv = 1;
                Label_jdk_status.Text = "已安装";
                Label_jdk_status.ForeColor = Color.Green;
                PictureBox_jdk_status.Image = Resources.complete;
                Button_next.Enabled = true;
                Button_jdk_install.Hide();
                InstallCompleted();
            }
            else
            {
                Label_jdk_status.Text = "未安装";
                Label_jdk_status.ForeColor = Color.Red;
                PictureBox_jdk_status.Image = Resources.error;
                Button_jdk_install.Show();
            }
        }

        private void InstallCompleted()
        {
            if (jdkEnv != 0 && vscEnv != 0)
                Button_next.Enabled = true;
        }

        private void Button_next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label_copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/12263994");
        }

        private void Form_EnvCheck_Shown(object sender, EventArgs e)
        {
            //隐藏按钮
            Button_jdk_install.Hide();
            Button_vsc_install.Hide();
        }    
    }
}
