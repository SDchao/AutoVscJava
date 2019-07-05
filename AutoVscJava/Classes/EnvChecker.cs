using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace AutoVscJava.Classes
{
    class EnvChecker
    {
        private static string vscPath = string.Empty;

        public static bool CheckJavaSE()
        {
            CmdResult result = CmdRunner.CmdRun("javac -version");
            string output = result.result.Substring(result.result.IndexOf("&exit") + 5);

            if(output.Contains("."))
                return true;
            return false;
        }

        public static bool CheckVscode()
        {
            string path = GetVscPath();
            if (path == string.Empty)
                return false;
            CmdResult result = CmdRunner.CmdRun(
                path.Substring(0,2) + 
                "\ncd " + path + "bin" + 
                "\ncode -version");
            string output = result.result.Substring(result.result.IndexOf("&exit") + 5);

            if (output.Contains("."))
                return true;
            return false;
        }

        public static bool CheckVscExtension()
        {
            string path = GetVscPath();
            CmdResult result = CmdRunner.CmdRun(
                path.Substring(0, 2) +
                "\ncd " + path + "bin" +
                "\ncode --list-extensions");
            if (result.result.Contains("vscjava.vscode-java-pack"))
                return true;
            else
                return false;
        }

        private static void InitVscodePath()
        {
            RegistryKey machineKey = 
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            RegistryKey userKey = 
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
            string[] machineKeyList = machineKey.GetSubKeyNames();
            string[] userKeyList = userKey.GetSubKeyNames();
            foreach (string keyName in machineKeyList)
            {
                RegistryKey key = machineKey.OpenSubKey(keyName);
                object name = key.GetValue("DisplayName");
                if(name != null && name.ToString().Contains("Microsoft Visual Studio Code"))
                {
                    vscPath = key.GetValue("InstallLocation").ToString();
                    return;
                }
            }

            foreach (string keyName in userKeyList)
            {
                RegistryKey key = userKey.OpenSubKey(keyName);
                object name = key.GetValue("DisplayName");
                if (name != null && name.ToString().Contains("Microsoft Visual Studio Code"))
                {
                    vscPath = key.GetValue("InstallLocation").ToString();
                    return;
                }
            }
        }

        public static string GetVscPath()
        {
            if(vscPath == string.Empty)
            {
                InitVscodePath();
            }

            return vscPath;
        }
    }
}
