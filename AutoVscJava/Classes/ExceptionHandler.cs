using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AutoVscJava.Classes
{
    class ExceptionHandler
    {
        public static void Error(Exception e)
        {
            Thread t = new Thread(() =>
            {
                DialogResult result = MessageBox.Show("啊偶，发生了以下错误哦" + Environment.NewLine
                    + e.Message + Environment.NewLine
                    + e.StackTrace + Environment.NewLine
                    + "您是否要向作者汇报以下错误？"
                    ,"被玩坏了",MessageBoxButtons.YesNo,MessageBoxIcon.Error);

                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("谢谢！错误信息已经复制到您的剪切板啦，即将打开反馈网页","被玩坏了");
                    Clipboard.SetText(e.Message + Environment.NewLine + e.StackTrace);
                    System.Diagnostics.Process.Start("https://github.com/SDchao/AutoVscJava/issues/new");
                }
                Application.Exit();
            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
    }
}
