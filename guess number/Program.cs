using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace guess_number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int TheN = num.Next(1, 100);
            int RP;
            Console.WriteLine("I will choose a number from 1->100 , and you will find it out");
            bool TF = false;
            Console.WriteLine("Try to cin");
            RP = Convert.ToInt32(Console.ReadLine());
            int cishu = 1;

            while(true)
            {
                
                if(TheN == RP)
                {
                    Console.WriteLine("Well done,you are right");
                    break;
                    
                }
                else
                {
                    cishu++;
                    if(RP > TheN)
                    {
                        Console.WriteLine("Try again! , too big");
                    }
                    else
                    {
                        Console.WriteLine("Try again! , small");
                    }

                    RP = Convert.ToInt32(Console.ReadLine());
                }
                

                
                
            }
            Thread.Sleep(500);
            Console.Write("you try {0}", cishu);
            Console.Write(" times");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
