using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class nent
    {
        private int n;
        public nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }

        public int descargar()
        {
            return n;
        }
        public bool esPrimo()
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
