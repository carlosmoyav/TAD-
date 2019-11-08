using System;

namespace CarlosMoyaTAD3B.TAD
{
    public class Cola
    {
        private int[] datos1 = new int[5];

        public int[] Datos1
        {
            get { return datos1; }
            set { datos1 = value; }
        }

        private int cabeza = -1;

        public int Cabeza
        {
            get { return cabeza; }
            set { cabeza = value; }
        }

        private int ultimo = -1;

        public int Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public void Eliminar()
        {
            if (Cabeza == -1 && Ultimo == -1)
                throw new Exception("No hay datos en la cola");
            else
            {
                if (Cabeza == Ultimo)
                {
                    Cabeza = -1;
                    Ultimo = -1;

                }
                else
                {
                    Cabeza++;
                }
            }
        }

        public void Agregarnum(int num)
        {
            if (Ultimo < (Datos1.Length - 1))
            {
                Ultimo++;
                Datos1[Ultimo] = num;
            }
        }
    }
}
