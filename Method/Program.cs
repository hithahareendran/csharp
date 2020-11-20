using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the FirstNumber");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            int secondNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine("Greatest Number");
            Console.WriteLine(max);
            Console.ReadLine();
        }
        public static int GetMax(int firstNumber,int secondNumber)
        {
            if(firstNumber>secondNumber)
            {
               
                return firstNumber;
            }
            else
            {
                
                return secondNumber;
            }
    }
}
}
