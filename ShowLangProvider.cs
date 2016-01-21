using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowLangProvider
{
    class ShowLangProvider
    {
        static void Main(string[] args)
        {
            foreach (CompilerInfo ci in CodeDomProvider.GetAllCompilerInfo())
            {
                foreach (string lang in ci.GetLanguages())
                    System.Console.Write("{0} ",lang);
                System.Console.WriteLine();
            }
        }
    }
}
