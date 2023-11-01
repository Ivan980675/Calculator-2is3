using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{


    internal class Program
    {



        static void Main(string[] args)
        {



            double firstvalue, twovalue;
            string operatorB;

            Console.WriteLine("Введите первое значение:");
            firstvalue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение:");
            twovalue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/' '^' 'sqrt' '%'");

            operatorB = Console.ReadLine();


            switch (operatorB)

            {
                case "+":
                    Console.WriteLine(firstvalue + twovalue);
                    break;

                case "-":
                    Console.WriteLine(firstvalue - twovalue);
                    break;

                case "*":
                    Console.WriteLine(firstvalue * twovalue);
                    break;

                case "/":
                    if (firstvalue == 0)
                        Console.WriteLine(0);
                    else if (twovalue == 0)
                        Console.WriteLine(0);
                    else

                        Console.WriteLine(firstvalue / twovalue);
                    break;

                case "%":
                    Console.WriteLine(Convert.ToDouble(firstvalue) % Convert.ToDouble(twovalue));
                    break;

                case "^":

                    Console.WriteLine(Math.Pow(Convert.ToDouble(firstvalue), Convert.ToDouble(twovalue)));
                    break;

                case "sqrt":
                    Console.WriteLine(Math.Pow(Convert.ToDouble(twovalue), 1.0 / Convert.ToDouble(firstvalue))); 
                    break;

               
            }
            Console.ReadKey();

        }


    }
 }

















