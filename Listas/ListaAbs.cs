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

        public abstract bool vacia(); // devuelve true si la lista esta vacia
        public abstract int primero(); // devuelve la direccion del primer elemento
        public abstract int segundo(); // devuelve la direccion del segundo elemento
        public abstract int fin(); // devuelve la direccion del ultimo elemento
        public abstract int posterior(int dir); // devuelve la direccion del elemento posterior al enviado
        public abstract int anterior(int dir); // devuelve la direccion del elemento anterior al enviado
        public abstract void insertar(int dir, string dato); // inserta un nuevo elemento en la direccion 
        public abstract void suprimir(int dir); // elimina el elemento de la direccion
        public abstract void modificarDato(int pos, string dato); // modifica la "posicion pos"  del dato de la lista
        public abstract string mostrar_lista(); // muestra todos los elementos de la lista
        public abstract string mostrar_lista_Invertida(); // muestra todos los elementos invertidos de la lista 
        public abstract bool valor_vacio(int dir);
        public abstract void modificarDatoUltimo(int pos, string dato); 



     

    }
}
