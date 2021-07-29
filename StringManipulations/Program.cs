using System;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, strRev, strReplaced,ch, strExtracted,strCopy;
            strRev = "";
            Console.WriteLine("1.-----------------------------------------------");
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            
            for(int i = str.Length-1; i>=0; i--)
            {
                strRev += str[i];
            }
            Console.WriteLine("Given string: {0}", str);
            Console.WriteLine("Reverse order: {0}",strRev);


            Console.WriteLine("2.-----------------------------------------------");
            strExtracted = str.Substring(1);
            Console.WriteLine("Given string: {0}", str);
            Console.WriteLine("Extracted string: {0}",strExtracted);   
            
            Console.WriteLine("3.-----------------------------------------------");
            Console.WriteLine("Given string: {0}", str);
            Console.WriteLine("Enter a character to replace");
            ch = Console.ReadLine();
            strReplaced = str.Replace(ch[0], '$');
            Console.WriteLine("Replaced String: {0}", strReplaced);

            Console.WriteLine("4.-----------------------------------------------");
            Console.WriteLine("Given string: {0}", str);
            strCopy = str;
            Console.WriteLine("Copied string: {0}", strCopy);
            Console.WriteLine("Modified string: {0}", str.ToUpper());



        }
    }
}
