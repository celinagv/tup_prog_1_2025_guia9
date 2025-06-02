using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] serie;
            int terminos;
            int contador;
            int valorAnterior = 0;
            int valorActual = 0;
            int proximoValor;


            Console.WriteLine("Ingrese la cantidad de terminos deseada");
            terminos = Convert.ToInt32(Console.ReadLine());
            serie = new int[terminos];

            contador = 1;

            
            valorActual = 1;
            serie[1] = valorActual;
            valorAnterior = 0;
            serie[0] = valorAnterior;
            

            for (int i = 2; i < terminos; i++)
            {
                
                    proximoValor = valorActual + valorAnterior;
                    serie[i] = proximoValor;
                    valorAnterior = valorActual;
                    valorActual = proximoValor;
               
                contador++;
            }


            for (int i = 0;i < terminos;i++)
            {
                Console.WriteLine(serie[i]);
            }
        }
    }
}
