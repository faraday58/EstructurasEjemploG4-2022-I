using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Armando",30));
            clientes.Add(new Cliente("Juan", 22));
            clientes.Add(new Cliente("Anahí", 21));
            clientes.Add(new Cliente("Laura", 20));

            Console.WriteLine("Nombre: {0} \n Edad: {1}", clientes[1].Nombre, clientes[1].Edad);

            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine("Nombre: {0} \n Edad: {1}", cliente.Nombre, cliente.Edad);
            }

            Console.ReadLine();
        }
    }
}
