using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("simvol daxil edin");
            int num = int.Parse(Console.ReadLine());
            double result = 0;

            if (num >= 1 && num <= 4)
            {
                switch (num)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        result = num1 / num2;
                        Console.WriteLine(result);
                        break;
                }
            }

























        }











    }












}
