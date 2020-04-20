using System;
using HelpMethods;
namespace HW_18_04
{
    
    class Program
    {
        delegate T uniMethod<T>(T a, T b);
        static void Main(string[] args)
        {
            uniMethod<dynamic> operatorMethod;
            System.Console.Write("Введите 1 число: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.Write("Введите 2 число: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.Write("Выберите операцию(+,-,*,/):\n::");
            string operation = Console.ReadLine();
            
            switch (operation)
            {
                case "+":
                operatorMethod = MathOperator.Plus;
                System.Console.WriteLine("Результат "+operatorMethod(x,y));
                break;
                case "-":
                operatorMethod = MathOperator.Minus;
                System.Console.WriteLine("Результат "+operatorMethod(x,y));
                break;
                case "*":
                operatorMethod = MathOperator.multiplication;
                System.Console.WriteLine("Результат "+operatorMethod(x,y));
                break;
                case "/":
                operatorMethod = MathOperator.division;
                System.Console.WriteLine("Результат "+operatorMethod((double)x,(double)y));
                break;
                default:
                System.Console.WriteLine("Error!");
                break;
            }
        }
    }

    
}
