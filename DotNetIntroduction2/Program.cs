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
            //6     проблема с выводом наоброт
            //
            //6.1   не понятно с дробной частью
            //      не понятно с точкой и запятой: System.Globalization.CultureInfo.InvariantCulture
            //      при вводе запятой, она игнорируется
            string answer = AskForChoice();
            
            while (answer != "q")
            {
                switch (answer)
                {
                    case "1":
                        Task1();
                        answer = AskForChoice();
                        break;
                    case "2":
                        Task2dot1();
                        answer = AskForChoice();
                        break;
                    case "2.1":
                        Task2dot1();
                        answer = AskForChoice();
                        break;
                    case "3":
                        Task3();
                        answer = AskForChoice();
                        break;
                    case "4":
                        Task4();
                        answer = AskForChoice();
                        break;
                    case "5":
                        Task5();
                        answer = AskForChoice();
                        break;
                    case "6":
                        Task6();
                        answer = AskForChoice();
                        break;
                    case "6.1":
                        Task6dot1();
                        answer = AskForChoice();
                        break;
                    case "7":
                        Task7();
                        answer = AskForChoice();
                        break;
                    default:
                        Console.Write("INPUT ERROR!!!\nTry again\n\n");
                        answer = AskForChoice();
                        break;
                }
            }
        }

        static string AskForChoice()
        {
            
            Console.WriteLine("Tasks:\t1  2  2.1  3  4  5  6  6.1  7");
            Console.WriteLine("\t***  Enter the task number, or enter \'q\' to quit  ***");
            return Console.ReadLine();
        }
        static void Task1()
        {
            Console.WriteLine("Task 1 displays numbers from 0 to 10");
            for (int i = 0; i <= 10; i++)
                Console.WriteLine("\t"+i);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task2()
        {
            Console.WriteLine("Task 2 displays numbers from 100 to 200");
            for (int i = 100; i <= 200; i++)
                Console.WriteLine("\t" + i);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task2dot1()
        {
            Console.WriteLine("Task 2.1 displays numbers from 200 to 100");
            for (int i = 200; i >= 100; i--)
                Console.WriteLine("\t" + i);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task3()
        {
            Console.WriteLine("Task 3 displays even numbers from 0 to 50");
            for (int i = 0; i <= 50; i++)
                if ((i%2 == 0) && (i != 0))
                Console.WriteLine("\t" + i);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task4()
        {
            Console.WriteLine("Task 4 displays the sum of numbers from 0 to 100");
            int sum = 0;
            for (int i = 0; i <= 100; i++)
                sum += i; 
            Console.WriteLine("\t" + sum);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task5()
        {
            Console.WriteLine("Task 5 displays the multiplication of numbers from 1 to 10");
            int multiplication = 1;
            for (int i = 1; i <= 10; i++)
                multiplication *= i;
            Console.WriteLine("\t" + multiplication);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task6()
        {
            Console.WriteLine("Task 6 displays the digits of entered integer number\n");
            Console.WriteLine("Input integer number: ");
            int mumber = int.Parse(Console.ReadLine());
            int number = mumber;
            int i = 0;
            while (number % 10 > 0)
            {
                Console.WriteLine(number % 10 + " ");
                number = number / 10;
                i++;
            }
            Console.WriteLine("Disgits qty: " + i);
            //for (int k =i; k >= 1; k--)
            //{ Console.WriteLine(mumber / (Math.Pow(10 * k)) + " ");
            //mumber = mumber % (10 * k); }
            
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
        static void Task6dot1()
        {
            Console.WriteLine("Displays separately a fractional, an integer part of a number");
            double number, intPart, fractPart;
            Console.WriteLine("Input double number: ");
            number = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            intPart = Math.Truncate(number);
            fractPart = number - intPart;
            Console.WriteLine("\nThe integer part of the number entered:\t\t"+intPart);
            Console.WriteLine("\nThe fractional part of the number entered:\t" + fractPart+"\n");
        }
        static void Task7()
        {
            Console.WriteLine("Task 7 displays the sum of digits of entered integer number\n");
            Console.WriteLine("Input integer number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, n = number;
            while (n % 10 > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine("The sum of digits of {0} is: {1}", number, sum);
            Console.WriteLine("\tDone\n--------------------------------------------------------------\n");
        }
    }
}