﻿using System;
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

            Thread checkJdkThread = new Thread(() =>
            {
                if(!EnvChecker.CheckJavaSE())
                {
                    Label_jdk_status.Text = "已安装";
                    Label_jdk_status.ForeColor = Color.Green;
                    PictureBox_status.Image = Resources.complete;
                    Button_next.Enabled = true;
                } else
                {
                    Label_jdk_status.Text = "未安装";
                    Label_jdk_status.ForeColor = Color.Red;
                    PictureBox_status.Image = Resources.error;
                    Button_install.Show();
                }
            });

            checkJdkThread.Start();
        }

        private void Form_EnvCheck_Shown(object sender, EventArgs e)
        {
            Button_install.Hide();
        }
    }
}
