using System;

namespace Homework_2_18._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.Write("Eded daxil edin: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int mod = num1 % 7;
                int total = 0;
                int remainder = 7 / 2;
                if (mod <= remainder)
                {
                    total = num1 - mod;
                    Console.Write("Verilmis edede yaxin 7-nin boluneni: ");
                    Console.WriteLine(total); ;
                }
                else if (mod > remainder)
                {
                    total = num1 + 7 - mod;
                    Console.Write("Verilmis edede yaxin 7-nin boluneni: ");
                    Console.WriteLine(total);
                }
                else { Console.WriteLine("7-e bolunur"); }
            
        }
    }
}
