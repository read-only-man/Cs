using System.CodeDom;

namespace HelloWorldCodeDOM
{
    partial class HelloWorldCodeDOM
    {
        static CodeNamespace BuildProgram()
        {
            // namespaceの作成
            var ns = new CodeNamespace("MetaWorld");
            // import編成
            var systemImport = new CodeNamespaceImport("System");
            // class作成
            var programClass = new CodeTypeDeclaration("Program");

            // mainメソッドの定義
            var methodMain = new CodeMemberMethod()
            {
                Attributes = MemberAttributes.Static,
                Name = "Main"
            };
            methodMain.Statements.Add(
                new CodeMethodInvokeExpression(
                    new CodeSnippetExpression("Console"),
                    "WriteLine",
                    new CodePrimitiveExpression("Hello World")
                    )
                );

            // コード構造の編成
            programClass.Members.Add(methodMain);
            ns.Imports.Add(systemImport);
            ns.Types.Add(programClass);
            return ns;
        }
    }
}
