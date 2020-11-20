using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            String fName = "First.txt";
            String sName = "Second.txt";
            StreamReader sr = new StreamReader(fName);
            StreamWriter sw = new StreamWriter(sName);
            int i = 1;
            while ((str = sr.ReadLine()) != null)
            {
                String output= "Line" + i + " :" + str;
                Console.WriteLine(output);
                sw.WriteLine(output);
                i++;
            }
            sr.Close();
            sw.Close();

            Console.ReadLine();

        }
    }
}
