using System;
using HelpMethods;
namespace HW_18_04
{
    
    class Program
    {
        delegate T uniMethod<T>(T a, T b);
        static void Main(string[] args)
        {
            
            uniMethod<dynamic> sp = MathOperator.Plus;
            var x = sp(2,"3");
            System.Console.WriteLine(x);
        }
    }

    
}
