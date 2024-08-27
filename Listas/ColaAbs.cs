using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public abstract class ColaAbs
    {

        protected int longitud;
        public int inicio;
        public int final;
        protected MemoriaImp m;

        public ColaAbs(MemoriaImp mem)
        {
            longitud = 0;
            inicio = -1;
            final = -1;
            m = mem;

        }

        public abstract bool vacia(); // devuelve true si la lista esta vacia
        public abstract int anterior(int dir); // devuelve la direccion del elemento anterior al enviado
        public abstract string primero(); // mostrar el primer elemento sin sacarlo
        public abstract void poner(string dato); // ingresar un elemento a la cola
        public abstract string sacar(); // mostrar el primer elemento sacandolo de la cola
        public abstract int posterior(int dir);
    }
}
