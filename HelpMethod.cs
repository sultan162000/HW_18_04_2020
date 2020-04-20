namespace HelpMethods
{
    public class MathOperator
    {
        public static T Plus<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}