using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public abstract class MemoriaAbs
    {
        protected const int MAX = 20;
        protected const int NULO = -1;
        public struct NodoM
        {
            public string dato;
            public int id;
            public int link;
        }
        public NodoM[] MEM = new NodoM[MAX];
        protected int libre;     
        
        public MemoriaAbs()
        {
    
            int i = 0;
            while( i < MEM.Length)
            {
                MEM[i].dato = "";
                MEM[i].id = i;
                MEM[i].link = i + 1;
                i++;
            }
            libre = 0;
            MEM[MAX-1].link = -1;
        }

        public abstract  void mostrar();
        public abstract void new_espacio(int cantidad);
        public abstract void delete_espacio(int dir);
        public abstract void delete_dir(int dir);
        public abstract int espacio_disponible();
        public abstract int espacio_ocupado();
        public abstract bool dir_libre(int dir);
        public abstract void poner_dato(int dir, int lugar, string valor);
        public abstract string obtener_dato(int dir, int lugar);
        public abstract void espacio_palabra(string cadena);

        public abstract void modificar_link(int dir, int nuevo_link);
        public abstract int espacio_libre();

    }
}
