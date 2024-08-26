using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public class MemoriaImp : MemoriaAbs
    {
        public override void delete_dir(int dir)
        {
            int x = dir;
            MEM[x].link = libre;
            libre = dir;

        }

        public override void delete_espacio(int dir)
        {
            int x = dir;
            while (MEM[x].link != - 1)
            {
                x= MEM[x].link; 
            }
            MEM[x].link = libre;
            libre = dir;
        }

        public override bool dir_libre(int dir)
        {
            int x = libre;
            bool c = false;
            while (x != -1 && c == false) { 
                if(x == dir)
                {
                    c = true;
                }
                x = MEM[x].link;
            }
            return c;
        }

        public override int espacio_disponible()
        {
            int x = libre;
            int c = 0;
            while (x != -1) {
                c++;
                x = MEM[x].link;
            }
            return c;
        }

        public override int espacio_libre()
        {
            return libre;
        }

        public override int espacio_ocupado()
        {
            int c = MAX - espacio_disponible();
            return c;
        }

        public override void espacio_palabra(string cadena)
        {
            
            int d = libre;
            for (int i = 0; i < cadena.Length; i++)
            {
            
                string letra = cadena[i].ToString();            
                MEM[d].dato = letra;
                d = MEM[d].link;
            
            }
            libre = MEM[d-1].link;
            MEM[d-1].link = -1;
        }

        public override void modificar_link(int dir, int nuevo_link)
        {
            MEM[dir].link = nuevo_link;
        }

        public override void mostrar()
        {
            Console.WriteLine("Dir Dato Link");
            Console.WriteLine("*---------------*");
            
            foreach (NodoM actual in MEM)
            {
                string dato = actual.dato;
                int link = actual.link;
                int dir = actual.id;
                Console.WriteLine("|" + dir + "\t| " + 
                        dato + "\t| " + link);
                dir++;
            }

        }

        public override void new_espacio(int cantidad)
        {
            
            int d = libre;
            for (int i = 0; i < cantidad-1; i++)
            {
                d= MEM[d].link;
                
            }
            libre = MEM[d].link;
            MEM[d].link = -1;
        }

        public override string obtener_dato(int dir, int lugar)
        {
            int z = dir;
            int i = 0;
            while (i < lugar - 1)
            {
                z= MEM[z].link;
                i++;
            }
            return MEM[z].dato;
        }

        public override void poner_dato(int dir, int lugar, string valor)
        {
            int z = dir;
            int i = 0;
            while (i < lugar - 1)
            {
                z = MEM[z].link;
                i++;
            }
            MEM[z].dato = valor;
            
        }
    }
}
