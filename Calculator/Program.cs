using System;
using System.Collections.Generic;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            Console.WriteLine("Enter expression to evaluate");
            String s = Console.ReadLine();
            String[] elements = s.Split(" ");

            st.Push(int.Parse(elements[0]));

            for(int i=0; i<elements.Length; i++)
            {

                if (elements[i] == "+")
                {
                    int nextElement = int.Parse(elements[++i]);
                    st.Push(st.Pop() + nextElement);
                }
                else if(elements[i] == "-")
                {
                    int nextElement = int.Parse(elements[++i]);
                    st.Push(st.Pop() - nextElement);
                }
            }
            Console.WriteLine("total is {0}", st.Pop());
        }
    }
}
