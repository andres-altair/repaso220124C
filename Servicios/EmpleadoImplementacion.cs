using repaso220124C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso220124C.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
       
        public void borrarCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto empleado = new ClienteDto();
            if (listaClientes.Count > 0)
            {
                Console.WriteLine("Indica el dni del cliente a borrar: ");
                string dniClienteABorrar = Console.ReadLine();
                ClienteDto clienteAuxiliar = new ClienteDto();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteABorrar))
                    {
                        clienteAuxiliar = cliente;
                    }
                }

                listaClientes.Remove(clienteAuxiliar);
            }
        }

        public void mostrarClientes(List<ClienteDto> listaClientes)
        {

            foreach (ClienteDto cliente in listaClientes)
            {
                Console.WriteLine("%%%%%%%%%%");
                Console.WriteLine("DNI: " + cliente.DniCliente);
                Console.WriteLine("NOMBRE: " + cliente.Apellido1Cliente + " " +
                    cliente.Apellido2Cliente + ", " + cliente.NombreCliente);
                string sn;
                if (cliente.EsValidado == true)
                {
                    sn = "si";
                }
                else
                {
                    sn = "no";
                }
                Console.WriteLine("ESTADO VALIDACIÓN: " + sn);
                Console.WriteLine("%%%%%%%%%%");
            }
        }

        public void validarCliente(List<ClienteDto> listaClientes)
        {

            List<ClienteDto> listaAuxiliar = new List<ClienteDto>();

            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    Console.WriteLine("DNI: " + cliente.DniCliente);
                    Console.WriteLine("NOMBRE: " + cliente.NombreCompletoCliente);
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    listaAuxiliar.Add(cliente);
                }

            }

            if (listaAuxiliar.Count > 0)
            {
                Console.WriteLine("Indica el dni del cliente a validar: ");
                string dniClienteAValidar = Console.ReadLine();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteAValidar))
                    {
                        cliente.EsValidado = true;
                        Console.WriteLine("El cliente con dni " + dniClienteAValidar + " ha sido validado");
                    }
                }
            }

        }
    }
}
