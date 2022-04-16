using System;

namespace Homework_2_18._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.Write("Eded daxil edin: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = num1 % 7;
                int total = 0;
                int num3 = 7 / 2;
                if (num2 <= num3)
                {
                    total = num1 - num2;
                    Console.Write("Verilmis edede yaxin 7-nin boluneni: ");
                    Console.WriteLine(total); ;
                }
                else if (num2 > num3)
                {
                    total = num1 + 7 - num2;
                    Console.Write("Verilmis edede yaxin 7-nin boluneni: ");
                    Console.WriteLine(total);
                }
                else { Console.WriteLine("7-e bolunur"); }
            
        }
    }
}
