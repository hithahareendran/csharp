using System;
using System.Collections;

namespace Push_and_pop
{
    class Program
    {
        static void Main(string[] args)
        { 
        Stack st = new Stack();
            Console.WriteLine("Enter the String: ");
         String s=Console.ReadLine();
            foreach(char c in s)
            {
                st.Push(c);
            }
            while(st.Count!=0)
            {
                Console.Write(st.Pop());
            }
            Console.ReadLine();
        }
    }
}
