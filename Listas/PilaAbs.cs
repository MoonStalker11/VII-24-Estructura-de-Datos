using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public abstract class PilaAbs
    {

        protected int longitud;
        protected int inicio;
        protected int final;
        protected MemoriaImp m;

        public PilaAbs(MemoriaImp mem)
        {
            longitud = 0;
            inicio = -1;
            final = -1;
            m = mem;

        }

        public abstract bool vacia(); // devuelve true si la pila esta vacia
        public abstract string cima(); // devuelve el dato del ultimo elemento de la pila
        public abstract void meter(string elemento); // ingresa un elemento al tope de la pila (como ultimo elemento)
        public abstract string sacar(); // devuelve el dato del ultimo elemento de la pila y luego lo saca de la pila
        public abstract string mostrar_pila(); // muestra la pila desde el ultimo al primero
        public abstract int anterior(int dir); // muestra la direccion anterior al ingresado
    }
}
