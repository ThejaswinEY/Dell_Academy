using System;

namespace Thejaswin_StringOperation
{
    class Program
    {
        static void Main(String[] args)
        {
            string name = "Thejaswin";
            string name2 = "Kannan";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(string.Concat(name,name2));
            Console.WriteLine(name.Contains("T"));
            
        }
    }
}