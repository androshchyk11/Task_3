using System;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            long c;
            Console.WriteLine("Введіть змінну типу Int ");
            while (true)
            {
                try
                {
                    Console.Write(" a = ");
                    a = Int32.Parse(Console.ReadLine());
                    break;
                } catch (Exception e)
                {
                    Console.WriteLine("Ви ввели неккоректні дані!!! Спробуйте знову");
                }
            }
            Console.WriteLine("Введіть змінну типу double ");
            while (true)
            {
                try
                {
                    Console.Write(" b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ви ввели неккоректні дані!!! Спробуйте знову");
                }
            }
            Console.WriteLine("Введіть змінну типу long ");

            while (true)
            {
                try
                {
                    Console.Write(" c = ");
                    c = Int64.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ви ввели неккоректні дані!!! Спробуйте знову");
                }
            }
            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);
            Console.ReadKey();
        }
    }
}
