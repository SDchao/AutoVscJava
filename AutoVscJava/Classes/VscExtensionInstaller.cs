using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoVscJava.Classes;

namespace AutoVscJava.Classes
{
    class VscExtensionInstaller
    {
        public static bool Install()
        {
            string path = EnvChecker.GetVscPath();
            CmdResult result = CmdRunner.CmdRun(
                path.Substring(0, 2) +
                "\ncd " + path + "bin" +
                "\ncode --install-extension vscjava.vscode-java-pack");
            if(result.result.Contains("is already installed") 
                || result.result.Contains("was successfully installed")) 
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("无法安装VScode拓展：" + Environment.NewLine
                    + result.result + Environment.NewLine
                    + "该过程并不影响Java SE环境配置" + Environment.NewLine
                    + "您可以稍后手动安装 vscjava.vscode-java-pack 插件"
                    ,"哎呦被玩坏了",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
