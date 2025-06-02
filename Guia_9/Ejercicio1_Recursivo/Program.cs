using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Recursivo
{
    internal class Program
    {


        static int terminos;
     

        static int CalculoFibonacci(int terminos)
        {

            if (terminos == 0 || terminos ==1)
            {
                return terminos;
            }

           return CalculoFibonacci(terminos -1) + CalculoFibonacci(terminos - 2);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de terminos deseada");
            terminos = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine(CalculoFibonacci(terminos));




        }
    }
}
