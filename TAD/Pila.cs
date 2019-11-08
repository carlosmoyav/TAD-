using System;

namespace CarlosMoyaTAD3B.TAD
{
    public class Pila
    {

        private int[] datos = new int[5];

        public int[] Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        private int cima = -1;

        public int Cima
        {
            get { return cima; }
            set { cima = value; }
        }

        public void Agregar(int num)
        {
            if(Cima<(Datos.Length-1))
            {
                Cima++;
                Datos[Cima] = num;
            }
        }

        public void Eliminar()
        {
            if (Cima == -1)
                throw new Exception("No hay datos en la pila");
            else
                Cima--;
            
        }

    }
}
