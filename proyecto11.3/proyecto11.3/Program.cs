using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float peso;
                int valor;
                int piezaConMasDe10kg = 0;
                int piezaConMenosDe9kg = 0;
                int piezaMedio = 0;
                int pieza = 0;
                int cantidad = 0;
                
                do
                {
                    pieza = pieza + 1;
                    Console.Write("Ingrese el peso de la pieza #"+pieza+": ");
                    peso = float.Parse(Console.ReadLine());                    

                    if (peso >= 9.8 && peso <= 10.2)
                    {
                        piezaMedio = piezaMedio + 1;
                    }
                    else if(peso > 10.2)
                    {
                        piezaConMasDe10kg = piezaConMasDe10kg + 1;
                    }
                    else
                    {
                        piezaConMenosDe9kg = piezaConMenosDe9kg + 1;
                    }

                    cantidad = cantidad + 1;

                    Console.Write("Escriba 0 para terminar o cuaquier numero para continuar.");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                } while (valor != 0);
                Console.WriteLine("Hay un total de " + piezaMedio + " piezas entre 9.8 kg y 10.2 kg.");
                Console.WriteLine("Hay un total de " + piezaConMasDe10kg + " piezas con mas de 10.2 kg.");
                Console.WriteLine("Hay un total de " + piezaConMenosDe9kg + " piezas con menos de 9.8 kg.");
                Console.WriteLine("Hay un total de "+pieza+" piezas procesadas.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
