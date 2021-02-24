using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeAndPositive
{
    class NegativeAndPositive
    {
        
        static void Main(string[] args)
        {

            int qtd;

            Console.WriteLine("Enter with the quantity: ");
            qtd = int.Parse(Console.ReadLine());

            if (qtd < 1)
            {
                do
                {
                    Console.WriteLine("Error! The quantity needs to be a positive number");
                    Console.Write("Enter again with the quantity: ");
                    qtd = int.Parse(Console.ReadLine());
                } while (qtd < 1);
            }

            Console.Clear();

            double[] number=new double[qtd];

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Enter with the {0}º number: ", i + 1);
                number[i] = double.Parse(Console.ReadLine());

                if (number[i] < 0)
                {
                    Console.WriteLine("This position in array had the negative number converted to a positive number");
                    Console.WriteLine("Pre-converted number: {0}", number[i]);

                    number[i] = number[i] * -1;

                    Console.WriteLine("Converted number: {0}", number[i]);

                }
                else if (number[i] > 0)
                {
                    Console.WriteLine("This position in array had the positive number converted to a negative number");
                    Console.WriteLine("Pre-converted number: {0}", number[i]);

                    number[i] = number[i] * -1;

                    Console.WriteLine("Converted number: {0}", number[i]);
                }
                else
                    Console.WriteLine("Zero is a neutral number");
            }

            Console.ReadKey();

        }
    }
}
