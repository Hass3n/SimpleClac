namespace Clac
{
    internal class Program
    {
        public static int sum(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");

            int x=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");

            int y=int.Parse(Console.ReadLine());

            Console.WriteLine(sum(x,y));
        }
    }
}
