using System;
using CarlosMoyaTAD3B.TAD;

namespace CarlosMoyaTAD3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pi = new Pila();

            for (int i = 0; i < 5; i++)
            {
                pi.Agregar(i);
            }
            Console.WriteLine("PILA");
            for (int i = pi.Cima; i > -1; i--)
            {
                Console.WriteLine(pi.Datos[i]);
            }




            Cola co = new Cola();
            for (int i = 6; i < 11; i++)
            {
                co.Agregarnum(i);
            }

            Console.WriteLine("COLA");
            for (int i = co.Ultimo; i > co.Cabeza; i--)
            {
                Console.WriteLine(co.Datos1[i]);
            }
        }
    }
}
