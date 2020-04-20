namespace HelpMethods
{
    public class MathOperator
    {
        public static T Plus<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        public static T Minus<T>(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }
        public static T multiplication<T>(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
        public static T division<T>(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
    }
}