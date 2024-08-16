using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public abstract class ListaAbs
    {
        protected int longitud;
        protected int inicio;
        protected int final;
        protected MemoriaImp m;


        public ListaAbs(MemoriaImp mem)
        {
            longitud = 0;
            inicio = -1;
            final = -1;
            m = mem;

        }

        public abstract void insertar(int dir, string dato);
        public abstract void suprimir(int dir);
        public abstract void modificarDato(int pos, string dato);
        public abstract bool vacia();
        public abstract int primero();
        public abstract int fin();
        public abstract int anterior(int dir);
        public abstract int posterior(int dir);
        public abstract string mostrar_lista();



     

    }
}
