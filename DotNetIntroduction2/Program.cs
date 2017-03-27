using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            showQuestion();
            string answer = Console.ReadLine();

            while (answer != "q")
            {
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("\tNumbers from 0 to 10");
                        for (int i = 0; i <= 10; i++)
                            Console.WriteLine(i);
                        showQuestion();
                        answer = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("2");
                        showQuestion();
                        answer = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("You are mistaken. Repeat the input, or enter \'q\' to quit: ");
                        answer = Console.ReadLine();
                        break;
                }
            }
            
        }
        public static void showQuestion()
        {            
            Console.WriteLine("\n\t1 display numbers from 0 to 10");
            Console.WriteLine("\t2 display numbers from 100 to 200");
            Console.WriteLine("\t2.1 display numbers from 200 to 100");
            Console.WriteLine("\t3 display even numbers from 0 to 50");
            Console.WriteLine("\t4 display the sum of numbers from 0 to 100");
            Console.WriteLine("\t5 display the multiplication of numbers from 1 to 10");
            Console.WriteLine("\t6 read the number from the keyboard and display all of its digits separately");
            Console.WriteLine("\t7 display separately a fractional, an integer part of a number");
            Console.WriteLine("\t7.1 display the sum of the digits of a number\n");
            Console.Write("Enter the task number, or enter \'q\' to quit: ");
        }



    }
}
