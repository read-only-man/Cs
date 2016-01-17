using System;
using System.IO;

namespace CopyTextWIthoutSpace
{
    // テキストファイルのコピーを行う。
    // その際、スペースをハイフンに変換する。

    class CopyTextWIthoutSpace
    {
        // ファイルの内容
        static readonly string text = @"A programmer, computer programmer, developer, coder, or software engineer is a person who writes computer software.
The term computer programmer can refer to a specialist in one area of computer programming or to a generalist who writes code for many kinds of software.
One who practices or professes a formal approach to programming may also be known as a programmer analyst.
A programmer's primary computer language (Assembly, COBOL, C, C++, C#, Java, Lisp, Python, etc.) is often prefixed to these titles,
and those who work in a Web environment often prefix their titles with Web.
The term programmer can be used to refer to a software developer, Web developer,
mobile applications developer, embedded firmware developer, software engineer, computer scientist,
or software analyst. However, members of these professions possess other software engineering skills, beyond programming;
for this reason, the term programmer, or code monkey,
is sometimes considered an insulting or derogatory oversimplification of these other professions.[1] This has sparked much debate amongst developers,
analysts, computer scientists, programmers, and outsiders who continue to be puzzled at the subtle differences in the definitions of these occupations.";

        static readonly int sp = (int)' ';
        static readonly int hi = (int)'-';

        static void Main(string[] args)
        {
            // 実行時パスの取得
            string strAppPath = System.AppDomain.CurrentDomain.BaseDirectory;
            // Console.WriteLine(strAppPath);

            // テスト用ファイルの作成
            using (StreamWriter sw0 = new StreamWriter(new FileStream(strAppPath + "test.txt", FileMode.Create)))
            {
                sw0.WriteLine(text);
            }

            // ファイルの作成
            using (StreamReader sr = new StreamReader(new FileStream(strAppPath + "test.txt", FileMode.Open)))
            using (StreamWriter sw = new StreamWriter(new FileStream(strAppPath + "out.txt", FileMode.Create)))
            {
                int ch;
                while ((ch = sr.Read()) != -1)
                {
                    ch = ch == sp ? hi : ch;
                    sw.Write((char)ch);
                }
            }
        }
    }
}
