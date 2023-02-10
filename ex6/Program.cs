using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            

            Console.WriteLine("Digite um numero");
            n1 =Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("o numero digitado é :" + n1);

            Console.WriteLine("o dobro de " + n1 + "  é  " +(n1 * 2));
            Console.WriteLine("a metade do seu numero é :"+(n1 / 2));  

            }
           
           
        }
    }

