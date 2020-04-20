using System;
using HelpMethods;
namespace HW_18_04
{

    class Program
    {
        delegate T uniMethod<T>(T a, T b);
        static void Main(string[] args)
        {

            System.Console.Write("Введите 1 число: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.Write("Введите 2 число: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.Write("Выберите операцию(+,-,*,/):\n::");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    uniMethod<double> plus = MathOperator.Plus;
                    System.Console.WriteLine("Результат " + plus(x, y));
                    break;
                case "-":
                    uniMethod<double> minus = MathOperator.Minus;
                    System.Console.WriteLine("Результат " + minus(x, y));
                    break;
                case "*":
                    uniMethod<double> mult = MathOperator.multiplication;
                    System.Console.WriteLine("Результат " + mult(x, y));
                    break;
                case "/":
                    if (x != 0 && y != 0)
                    {
                        uniMethod<double> div = MathOperator.division;
                        System.Console.WriteLine("Результат " + div((double)x, (double)y));
                    }
                    else System.Console.WriteLine("Error!");
                    break;
                default:
                    System.Console.WriteLine("Error!");
                    break;
            }
        }
    }


}
