﻿using repaso220124C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso220124C.Servicios
{
    internal class ClienteImplemtacion : ClienteInterfaz
    {
        public void accesoCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("ACCESO CLIENTE (LOGIN)");
            Console.WriteLine("Email: ");
            string emailAcceso = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string contraseniaAcceso = Console.ReadLine();

            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.EmailCliente.Equals(emailAcceso) &
                    cliente.ContraseniaCliente.Equals(contraseniaAcceso) &
                    cliente.EsValidado == true)
                {

                    Console.WriteLine("INICIO DE SESIÓN CORRECTO");

                }
                else
                {

                    Console.WriteLine("ERROR EN INICIO DE SESIÓN");

                }
            }
        }

        public void registroNuevoCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto nuevoCliente = new ClienteDto();
            Console.WriteLine("REGISTRO DE NUEVO CLIENTE");
            long id = calcularNuevoId(listaClientes);
            Console.WriteLine("Indique el dni: ");
            string dni = Console.ReadLine();
            Console.WriteLine("Indique el nombre completo separado por espacios");
            string nombreConEspacios = Console.ReadLine();
            Console.WriteLine("Indique el email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Indique la contraseña: ");
            string contrasenia = Console.ReadLine();

            
            listaClientes.Add(nuevoCliente);
        }

        private long calcularNuevoId(List<ClienteDto> listaClientes)
        {
            long idCalculado;
            int tamanioLista = listaClientes.Count;
            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaClientes[tamanioLista - 1].IdCliente + 1;
            }

            return idCalculado;
        }
    }
}
