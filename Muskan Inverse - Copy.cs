using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str = "raj kumar sharma";
        string[] strArr = str.ToUpper().Split(" ");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < strArr.Length; i++)
        {
            var str1 = strArr[i].ToLower();
            String str2 = strArr[i].Replace(strArr[i][0], str1[0]);
            sb.Append(str2 + "  ");

        }
        Console.WriteLine(sb);
    }
}
