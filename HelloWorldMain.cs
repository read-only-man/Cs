using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;

namespace HelloWorldCodeDOM
{
    partial class HelloWorldCodeDOM
    {
        static void Main(String[] args)
        {
            CodeNamespace prgNameSpace = BuildProgram();
            var compilerOptions = new CodeGeneratorOptions()
            {
                IndentString = " ",
                BracingStyle = "C",
                BlankLinesBetweenMembers = false
            };
            foreach (CompilerInfo ci in CodeDomProvider.GetAllCompilerInfo())
            {
                var codeText = new StringBuilder();
                String ln = ci.GetLanguages()[0];
                using (var codeWriter = new StringWriter(codeText))
                {
                    CodeDomProvider.CreateProvider(ln)
                        .GenerateCodeFromNamespace(prgNameSpace, codeWriter, compilerOptions);
                }
                Console.WriteLine("lang is " + ln);
                Console.WriteLine(codeText.ToString());
                Console.WriteLine();
            }

        }
    }
}
