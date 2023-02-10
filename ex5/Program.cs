using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;

            Console.WriteLine("digite o primeiro numero :");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo numero :");
            n2 = Convert.ToDouble(Console.ReadLine());

            {
                if (n1 > n2)
                {

                    Console.WriteLine("O primeiro valor digitado é maior");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine("O segundo valor digitado é maior");
                }
                else if (n1 == n2)
                {
                    Console.WriteLine("Os valores são iguais");
                }

            }
        
      
                



            

        
        
        }


    }
}
