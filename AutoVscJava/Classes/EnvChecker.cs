using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoVscJava.Classes
{
    class EnvChecker
    {       
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
            CmdResult result = CmdRunner.CmdRun("code -version");
            string output = result.result.Substring(result.result.IndexOf("&exit") + 5);
            
            if (output.Contains("."))
                return true;
            return false;
        }
    }
}
