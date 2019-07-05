using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SevenZip;

namespace AutoVscJava.Classes
{
    class JdkInstaller
    {
        static string targetPath;
        public static bool Install(string path)
        {
            targetPath = path;
            try
            {
                //异步设置环境变量
                var t = Task.Run(() =>
                {
                    SetEnvVar();
                });

                //开始解压
                bool extractResult = ExtractJdk();

                //等待环境变量设置
                t.Wait();
                return extractResult;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                ExceptionHandler.Error(e);
                return false;
            }
        }

        private static bool ExtractJdk()
        {
            if (!File.Exists("jdk.7z"))
            {
                MessageBox.Show("没有找到目录下的jdk.7z！\n请阅读下载页的使用说明", "缺失安装文件");
                return false;
            }
            
            try
            {
                SevenZipExtractor extractor = new SevenZipExtractor("jdk.7z");
                
                List<string> filePathsInSZ = new List<string>();
                foreach(var data in extractor.ArchiveFileData)
                {
                    if(!data.IsDirectory)
                    {
                        filePathsInSZ.Add(data.FileName);
                    }
                }

                extractor.ExtractFiles(targetPath, filePathsInSZ.ToArray());

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
                ExceptionHandler.Error(e);
                return false;
            }
        }

        private static void SetEnvVar()
        {
            Environment.SetEnvironmentVariable("JAVA_HOME", targetPath, EnvironmentVariableTarget.User);

            string pathVar = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            Console.WriteLine(pathVar);
            if (!pathVar.Contains("%JAVA_HOME%\\bin") || !pathVar.Contains(targetPath + "\\bin"))
            {
                if (!pathVar.EndsWith(";") && pathVar != string.Empty)
                {
                    pathVar += ";";
                }
                pathVar += "%JAVA_HOME%\\bin;" + targetPath + "\\bin;";
                Environment.SetEnvironmentVariable("PATH", pathVar, EnvironmentVariableTarget.User);
            }
        }
    }
}
