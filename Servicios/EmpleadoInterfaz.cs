using repaso220124C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso220124C.Servicios
{
    internal interface EmpleadoInterfaz
    {
        public void validarCliente(List<ClienteDto> listaClientes);
        public void borrarCliente(List<ClienteDto> listaClientes);
        public void mostrarClientes(List<ClienteDto> listaClientes);
    }
}
