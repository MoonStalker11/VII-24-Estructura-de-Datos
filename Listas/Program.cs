using System;
namespace Memoria
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();
            ListaImp lista = new ListaImp(memoria);
            lista.insertar(0, "hola");
            lista.insertar(0, "mundo");
            lista.insertar(0, "erick");
            lista.insertar(2, "casa");
            lista.modificarDato(3, "eri2");

            lista.suprimir(2);

            // memoria.espacio_palabra("erick");           
            memoria.mostrar();
            Console.WriteLine("libre: " + memoria.espacio_libre());
            Console.WriteLine("primer elemento: " + lista.primero());
            Console.WriteLine("ultimo elemento: " + lista.fin());
            Console.WriteLine("lista: " + lista.mostrar_lista());


            //memoria.mostrar();
            //memoria.espacio_palabra("er");
            //memoria.new_espacio(2);
            //memoria.mostrar();
            //lista.insertar(4, "rene");
            //memoria.mostrar();





            //memoria.delete_espacio(0);           

            //memoria.mostrar();
            //int resp = memoria.espacio_disponible();
            //Console.WriteLine("espacio libre " + resp);
            //resp = memoria.espacio_ocupado();
            //Console.WriteLine("espacio ocupado " + resp);

            //bool resp2 = memoria.dir_libre(2);
            //Console.WriteLine("espacio libre? " + resp2);

        }

    }
}