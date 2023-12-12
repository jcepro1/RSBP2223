using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        //examnes


        //1
        public void intercambiarFilas(int f1, int f2)
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                int aux = x[f1, c1];
                x[f1, c1] = x[f2, c1];
                x[f2, c1] = aux;
            }
        }
        public int cantPrimosFilas(int f1, int cc)
        {
            int cant = 0;
            nent n1 = new nent();
            for (int c1 = 1; c1 <= cc; c1++)
            {
                n1.cargar(x[f1, c1]);
                if (n1.esPrimo())
                {
                    cant++;
                }
            }
            return cant;
        }

        public void pregunta1primos()
        {
            c = c + 1;
            for (int f1 = 1; f1 <= f; f1++)
            {
                int nprimos1 = cantPrimosFilas(f1, c - 1);
                x[f1, c] = nprimos1;
                for (int f2 = f1 + 1; f2 <= f; f2++)
                {
                    int nprimos2 = cantPrimosFilas(f2, c - 1);
                    if (nprimos1 > nprimos2)
                    {
                        intercambiarFilas(f1, f2);
                    }
                }
            }
        }




    }
}
