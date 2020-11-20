using System;
using System.Linq;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            for(int i=0;i<20;i++)
            {
                try
                {
                    char ch = str[i];
                    Console.Write(ch);

                }
                catch(Exception ignore)
                {
                    Console.Write("*");
                }
             


            }
            Console.ReadLine();
        }
    }
}
