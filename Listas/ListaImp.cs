using System;

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
            else if (longitud == 1) // (dir == -1) Insertar al final si dir es -1
            {
                m.modificar_link(primero( ), libre);  // m.modificar_link(final, libre);
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

        public override void modificarDatoUltimo(int pos, string dato)
        {
            m.poner_dato(primero(),longitud,dato);
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
            return lista_ordenada.TrimStart(',', ' ');
        }

        public override string mostrar_lista_Invertida()
        {
            string lista_ordenada = "";
            int dir = primero();
            while (dir != -1)
            {
                lista_ordenada = m.MEM[dir].dato + ", " + lista_ordenada;
                dir = m.MEM[dir].link;
            }
            return lista_ordenada.TrimStart(',', ' ');
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

        public override int segundo()
        {
            return posterior(primero());
        }

        public override void suprimir(int dir)
        {
            if (vacia())
            {
                return;
            }
            else if (dir == primero())
            {
                inicio = posterior(primero());
                m.delete_dir(dir);
                longitud--;
                if (vacia()) final = -1;
            }
            else if (dir == fin())
            {
                final = anterior(fin());
                m.modificar_link(final, -1);
                m.delete_dir(dir);
                longitud--;
                if (vacia()) inicio = -1;
            }
            else
            {
                m.modificar_link(anterior(dir), posterior(dir));
                m.delete_dir(dir);
                longitud--;
            }
        }

        public override bool vacia()
        {
            return longitud == 0;
        }

        public override bool valor_vacio(int dir)
        {
            string valor = m.obtener_dato(dir,0);
            if (valor == "")
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
