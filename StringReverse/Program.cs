using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string to reverse");
            String str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadLine();
        }
    }
}
