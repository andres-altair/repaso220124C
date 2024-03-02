using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso220124C.Dtos
{
    internal class ClienteDto
    {
        long idCliente;
        string dniCliente = "aaaaa";
        string nombreCliente = "aaaaa";
        string apellido1Cliente = "aaaaa";
        string apellido2Cliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        string emailCliente = "aaaaa";
        string contraseniaCliente = "aaaaa";
        bool esValidado = false;
        public ClienteDto() { }

        public ClienteDto( string dniCliente, string nombreCliente, string apellido1Cliente, string apellido2Cliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente, bool esValidado)
        {
            
            this.dniCliente = dniCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            string[] array = nombreCompletoCliente.Split(' ');
            this.nombreCliente = array[0];
            this.apellido1Cliente = array[1];
            this.apellido2Cliente = array[2];
            
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.esValidado = esValidado;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }
    }
}
