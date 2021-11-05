﻿using System;

namespace EstructurasEjemploG4_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente;
            cliente.Nombre = "Armando";
            cliente.Edad = 30;

            Console.WriteLine("Nombre: {0} \nEdad: {1} ",cliente.Nombre,cliente.Edad);
            

            Cliente[] clientes = new Cliente[2];


            for (int i=0; i< clientes.Length; i++  )
            {
                Console.WriteLine("Ingresa el nombre del cliente: ");
                clientes[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad del cliente: ");
                clientes[i].Edad = byte.Parse (Console.ReadLine());
                Console.WriteLine("Ingresa la calle dónde vive el cliente");
                clientes[i].direccion.Calle = Console.ReadLine();
                Console.WriteLine("Ingresa el número Interior ");
                clientes[i].direccion.numeroInterior = byte.Parse( Console.ReadLine());
                Console.WriteLine("Ingresa el número Exterior");
                clientes[i].direccion.numeroExterior = short.Parse(Console.ReadLine());

            }

            foreach(Cliente otroCliente in clientes   )
            {
                Console.WriteLine("Nombre: {0} \n Edad: {1}", otroCliente.Nombre, otroCliente.Edad);
                Console.WriteLine("Dirección: \n\t Calle {0} \n\t Número Interior: {1} \n\t Número Exterior {2}", otroCliente.direccion.Calle, otroCliente.direccion.numeroInterior, otroCliente.direccion.numeroExterior);
            }
            Console.ReadLine();
        }
    }


    struct Cliente
    {
        public string Nombre;
        public byte Edad;
        public Direccion direccion;
    }

    struct Direccion
    {
        public string Calle;
        public byte numeroInterior;
        public short numeroExterior;
    }
}
