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

        public abstract bool vacia();
        public abstract string primero();
        public abstract void poner(string elemento);
        public abstract string sacar();
        public abstract int posterior(int dir);
    }
}
