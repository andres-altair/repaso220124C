using repaso220124C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso220124C.Servicios
{
    internal interface ClienteInterfaz
    {
        public void registroNuevoCliente(List<ClienteDto> listaClientes);

        public void accesoCliente(List<ClienteDto> listaClientes);
    }
}
