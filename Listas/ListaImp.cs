using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public class ListaImp : ListaAbs
    {
        public ListaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int anterior(int dir)
        {
            if (vacia())
            {
                return -1;
            }
            if (dir == primero())
            {
                return -1;
            }
            int actual = primero();
            while (m.MEM[actual].link != dir)
            {
                actual = m.MEM[actual].link;
            }
            return actual;
        }

        public override int fin()
        {
            return final;
        }

        public override void insertar(int dir, string dato)
        {
            int libre = m.espacio_libre();
            m.new_espacio(1);
            m.poner_dato(libre, 0, dato);
            if (vacia())
            {
                inicio = libre;
                final = libre;
                longitud++;
            }
            else if (longitud == 1)
            {
                m.modificar_link(primero(), libre);
                final = libre;
                longitud++;
            }
            else if (dir == primero())
            {
                m.modificar_link(libre, posterior(primero()));
                m.modificar_link(primero(), libre);
                longitud++;
            }
            else
            {
                m.modificar_link(anterior(dir), libre);
                m.modificar_link(libre, dir);
                longitud++;
            }

        }

        public override void modificarDato(int pos, string dato)
        {

            m.poner_dato(primero(), pos, dato);

        }

        public override string mostrar_lista()
        {

            string lista_ordenada = "";
            int dir = primero();
            while (dir != -1)
            {
                lista_ordenada = lista_ordenada + ", " + m.MEM[dir].dato;
                dir = m.MEM[dir].link;
            }
            return lista_ordenada;
        }

        public override int posterior(int dir)
        {
            if (vacia())
            {
                return -1;
            }
            int actual = primero();
            while (actual != dir)
            {
                actual = m.MEM[actual].link;
            }
            return m.MEM[actual].link;
        }

        public override int primero()
        {
            return inicio;
        }

        public override void suprimir(int dir)
        {
            if (vacia())
            {

            }else if( dir == primero())
            {
                inicio = posterior(primero());
                m.delete_dir(dir);
                longitud--;

            }else if(dir == fin())
            {
                final = anterior(fin());
                m.modificar_link(final, -1);
                m.delete_dir(dir);
                longitud--;
            }
            else
            {
                m.modificar_link(anterior(dir), posterior(dir));
                m.delete_dir(dir);
            }
        }

        public override bool vacia()
        {
            if (longitud == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
