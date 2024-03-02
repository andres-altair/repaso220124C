using repaso220124C.Servicios;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace repaso220124C.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplemetacion();

            int opcion;
            bool cerrar = false;

            do
            {
                opcion = mi.menu();
                switch (opcion)
                {

                    case 0:
                        Console.WriteLine("Se cierra la aplicación");
                        cerrar = true;
                        break;
                    case 1:
                        Console.WriteLine("VERSIÓN EMPLEADO");
                        mi.menuEmpleado();

                        break;
                    case 2:
                        Console.WriteLine("VERSIÓN CLIENTE");
                        mi.menuCliente();
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción aceptable");
                        break;
                }

            } while (!cerrar);



        }
    }
}