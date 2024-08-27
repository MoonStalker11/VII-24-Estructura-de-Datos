using System;

namespace Memoria
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();
            ListaImp lista = new ListaImp(memoria);
            PilaImp pila = new PilaImp(memoria);
            //ColaImp cola = new ColaImp(memoria);
            
            pila.meter("hola");
            pila.meter("adios");
            pila.meter("nuevo");
            Console.WriteLine(pila.mostrar_pila());
            memoria.mostrar();

            /*
            pila.meter("hola");
            lista.insertar(0, "l1");
            lista.insertar(lista.primero(), "l2");
            memoria.new_espacio(2);
            pila.meter("adios");
            memoria.mostrar();
            */


            /*
            lista1.insertar(0, "o");
            lista2.insertar(1, "9");
            lista1.insertar(lista1.primero(), "h");
            lista1.insertar(lista1.primero(), "a");
            
            lista2.insertar(1, "1");
            lista2.insertar(1, "1");

            memoria.mostrar();
            Console.WriteLine("lista 1: " + lista1.mostrar_lista());
            */

            /*
            lista.insertar(0,"hola");
            lista.insertar(0,"mundo");
            lista.insertar(0,"erick");
            lista.insertar(2,"casa");


            memoria.mostrar();
            Console.WriteLine("libre: " + memoria.espacio_libre());
            Console.WriteLine("primer elemento: " + lista.primero());
            Console.WriteLine("ultimo elemento: " + lista.fin());
            Console.WriteLine("lista: " + lista.mostrar_lista());
            */


            /*
            memoria.espacio_palabra("erick");
            memoria.mostrar();
            int res = lista.posterior(2);
            Console.WriteLine("el siguiente de 2 es " + res);
            */




            /*Memoria
            memoria.mostrar();
            memoria.espacio_palabra("erick");
            memoria.new_espacio(2);
            memoria.mostrar();

            //memoria.delete_espacio(0);
            
            //memoria.mostrar();
            int resp = memoria.espacio_disponible();
            Console.WriteLine("espacio libre " + resp);
            resp = memoria.espacio_ocupado();
            Console.WriteLine("espacio ocupado  " + resp);
            
            bool resp2 = memoria.dir_libre(2);
            Console.WriteLine("espacio libre? " + resp2);
            */
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            // 1. Insertar tres elementos en la pila (A, B, C)
            pila.meter("A");
            pila.meter("B");
            pila.meter("C");

            // 2. Insertar dos elementos en la cola (99, 88)
            cola.poner("99");
            cola.poner("88");

            // 3. Insertar dos elementos en la lista (mochi, pocky)
            lista.insertar(-1, "mochi"); // Insertar al final
            lista.insertar(-1, "pocky"); // Insertar al final

            // 4. Si la pila no está vacía, sacar un elemento de la pila y añadirlo a la lista al final
            if (!pila.vacia())
            {
                string elementoPila = pila.sacar();
                lista.insertar(lista.fin(), elementoPila);
            }

            // 5. Si la cola no está vacía, sacar un elemento de la cola y añadirlo a la lista al inicio
            if (!cola.vacia())
            {
                string elementoCola = cola.sacar();
                lista.insertar(lista.primero(), elementoCola);
            }

            // Mostrar el resultado
            Console.WriteLine("Contenido de la pila:");
            Console.WriteLine(pila.mostrar_pila());

            Console.WriteLine("Contenido de la cola:");
            Console.WriteLine(cola.mostrar_cola());

            Console.WriteLine("Contenido de la lista:");
            Console.WriteLine(lista.mostrar_lista());

            Console.WriteLine("Estado de la memoria:");
            memoria.mostrar();

            */
        
        }
    }
}
