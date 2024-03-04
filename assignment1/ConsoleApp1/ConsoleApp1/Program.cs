using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            int m = 0;
            int sum = 0;
            Console.Write("Please input an integer number:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input an integer number:");
            s = Console.ReadLine();
            m = Int32.Parse(s);
            Console.Write("Please choose an operator:");
            s = Console.ReadLine();
            switch (s)
            {
                case "+":
                    sum = n + m;
                    break;
                case "-":
                    sum = n - m;
                    break;
                case "/":
                    sum = n / m;
                    break;
                case "*":
                    sum = n * m;
                    break;
                /* 您可以有任意数量的 case 语句 */
                default: /* 可选的 */
                    sum = n + m;
                    break;
            }
            Console.Write("the answer :{0}",sum);
        }
    }
}