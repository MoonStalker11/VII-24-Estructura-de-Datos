using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public class PilaImp : PilaAbs
    {
        public PilaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int anterior(int dir)
        {


            if (vacia())
            {
                return -1;
            }
            if (dir == inicio)
            {
                return -1;
            }
            int actual = inicio;
            while (m.MEM[actual].link != dir)
            {
                actual = m.MEM[actual].link;
            }
            return actual;


        }

        public override string cima()
        {
            if (vacia())
            {
                return "null";
            }
            else
            {
                string resp = m.obtener_dato(inicio, longitud);
                return resp;
            }
        }

        public override void meter(string elemento)
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

        public override string mostrar_pila()
        {

            PilaImp pilaAux = new PilaImp(m);
            string ordenado = "";

            while (!vacia())
            {
                string dato = sacar();
                pilaAux.meter(dato);
                ordenado = ordenado + ", " + dato;
            }
            while (!pilaAux.vacia())
            {
                string dato = pilaAux.sacar();
                meter(dato);
            }

            return ordenado.TrimStart(',', ' ');
        }

        public override string sacar()
        {
            if (vacia())
            {
                return "NULL";
            }
            else if (longitud == 1)
            {
                string dato = m.obtener_dato(inicio, longitud);
                m.delete_dir(final);
                inicio = -1;
                final = -1;
                longitud--;
                return dato;
            }
            else
            {
                string dato = m.obtener_dato(inicio, longitud);
                int aux = anterior(final);
                m.modificar_link(anterior(final), -1);
                m.delete_dir(final);
                final = aux;
                longitud--;
                return dato;
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
