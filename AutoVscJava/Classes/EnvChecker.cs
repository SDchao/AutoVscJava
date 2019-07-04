using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoVscJava.Classes
{
    class EnvChecker
    {       
        public static bool CheckJava()
        {
            CmdResult result = CmdRunner.Run("java", "-version");
            if (result.error.Contains("Java(TM) SE Runtime Environment"))
                return true;
            return false;
        }

        public static bool CheckJavaSE()
        {
            CmdResult result = CmdRunner.CmdRun("javac -version");
            string output = result.result.Substring(result.result.IndexOf("&exit") + 6);
            Console.WriteLine(output);
            if(output.Contains("."))
                return true;
            return false;
        }
    }
}
