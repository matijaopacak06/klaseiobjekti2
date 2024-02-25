using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    public class KlasaC
    {
        public int Zbroj(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public double Prosjek(int[] numbers)
        {
            int sum = Zbroj(numbers);
            return (double)sum / numbers.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            KlasaC obj = new KlasaC();
            int[] userNumbers = new int[5];

            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int zbroj = obj.Zbroj(userNumbers);
            double prosjek = obj.Prosjek(userNumbers);

            Console.WriteLine($"Sum of numbers: {zbroj}");
            Console.WriteLine($"Average of numbers: {prosjek}");
        }
    }

}
