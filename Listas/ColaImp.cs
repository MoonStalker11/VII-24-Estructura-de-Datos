using System;

namespace Memoria
{
    public class ColaImp : ColaAbs
    {
        public ColaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int posterior(int dir)
        {
            if (vacia())
            {
                return -1;
            }
            int actual = inicio;
            while (actual != dir)
            {
                actual = m.MEM[actual].link;
            }
            return m.MEM[actual].link;
        }

        public override void poner(string elemento)
        {
            int libre = m.espacio_libre();
            m.new_espacio(1);
            m.poner_dato(libre, 0, elemento);
            if (vacia())
            {
                inicio = libre;
                final = libre;
                longitud++;
            }
            else
            {
                m.modificar_link(final, libre);
                final = libre;
                longitud++;
            }
        }

        public override string primero()
        {
            if (vacia())
            {
                return "NULL";
            }
            string dato = m.obtener_dato(inicio, 0);
            return dato;
        }

        public override string sacar()
        {
            if (vacia())
            {
                return "NULL";
            }
            int borrado = posterior(inicio);
            string dato = m.obtener_dato(inicio, 0);            
            m.delete_dir(inicio);
            inicio = borrado;
            longitud--;
            return dato;
        }

        public override bool vacia()
        {
            return longitud == 0;
        }

        public string mostrar_cola()
        {
            string cola_ordenada = "";
            int dir = inicio;
            while (dir != -1)
            {
                cola_ordenada = cola_ordenada + ", " + m.MEM[dir].dato;
                dir = posterior(dir);
            }
            return cola_ordenada.TrimStart(',', ' ');
        }
    }
}
