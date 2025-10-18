namespace Calc
{
    public class Program
    {
        // اجعل الدالة public static علشان مشروع الاختبار يشوفها
        public static int sum(int x, int y)
        {
            return x + y;
        }


        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(sum(x, y));


            Console.WriteLine("Enter first number");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(w, z));
        }
    }
}
