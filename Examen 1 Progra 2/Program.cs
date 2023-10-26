using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Progra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMenu menu = new clsMenu();
            int opcion;

            do
            {
                menu.MostrarMenu();
                Console.WriteLine("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu.AgregarEmpleado(); break;

                    case 2:
                        menu.ConsultarEmpleado(); break;

                    case 3:
                        menu.ModificarEmpleado(); break;

                    case 4:
                        menu.BorrarEmpleado(); break;

                    case 5:
                        menu.InicializarArreglos(); break;

                    case 6:
                        menu.Reportes(); break;

                    case 7:
                        Console.WriteLine("Salir, gracias"); break;
                    default:
                        Console.WriteLine("No existe la opcion");  break;
                }
            } while (opcion != 7);

            Console.ReadLine();
        }
    }
}