using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Progra_2
{
    internal class clsMenu
    {
        private List<Clsempleado> empleados = new List<Clsempleado>();

        

        public void MostrarMenu()
        {
            
            Console.WriteLine("1.Agregar Nuevo Empleado");
            Console.WriteLine("2.Consultar Empleado");
            Console.WriteLine("3.Modificar Empleado");
            Console.WriteLine("4.Borrar Empleado");
            Console.WriteLine("5.Inicializar Arreglos");
            Console.WriteLine("6.Reportes");
            Console.WriteLine("7.Salir");
            Console.WriteLine("Digite una opcion: ");
        }

        public void AgregarEmpleado()
        {
            
            Console.WriteLine("Ingrese los datos del empleado:");
            Console.WriteLine("Cedula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Direccion: ");
            string direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Clsempleado empleado = new Clsempleado(cedula, nombre, direccion, telefono, salario);
            empleados.Add(empleado);
            Console.WriteLine("Empleado Agregado Correctamente!");

        }

        public void ConsultarEmpleado()
        {
            
            Console.WriteLine("Empleado");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}| Nombre: {empleado.Nombre}| Direccion: {empleado.Direccion}| Telefono: {empleado.Telefono}| Salario: {empleado.Salario}");
            }
        }

        public void ModificarEmpleado()
        {
            
            Console.WriteLine("Ingrese la cedula correcta del empleado: ");
            string cedula = Console.ReadLine();
            Clsempleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Ingrese los nuevos datos del empleado");
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Direccion: ");
                string direccion = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Empleado modificado correctamente");
            }
            else
            {
                Console.WriteLine("Empleado no Encontrado");
            }
        }

        public void BorrarEmpleado()
        {
            
            Console.WriteLine("Ingrese la ceduda del empleado que desea borrar: ");
            string cedula = Console.ReadLine();
            Clsempleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado Eliminado Correctamente");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado");
            }
        }

        public void InicializarArreglos()
        {
            
            empleados.Clear();
            Console.WriteLine("Inicializado el arreglo de empleados");
        }

        public void Reportes()
        {
            
            int opcion;

            do
            {
                Console.WriteLine("Reportes de empleados: ");
                Console.WriteLine("1.Consultar empleados por Numero de Cedula");
                Console.WriteLine("2.Lista de empleados Ordenados por nombre");
                Console.WriteLine("3.Calcular y mostrar el promedio de salarios");
                Console.WriteLine("4.Calcular y mostrar el salario mas alto y el mas bajo");
                Console.WriteLine("5.Regresar el menu Principal");
                Console.WriteLine("Seleccione una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConsultarEmpleadosPorCedula(); break;

                    case 2:
                        ListaEmpleadosOrdenadosPorNombre(); break;

                    case 3:
                        CalcularPromedioDeSalario(); break;

                    case 4:
                        CalcularSalarioMasAltoYMasBajo(); break;

                    case 5: break;

                    default:
                        Console.WriteLine("Opcion Invalida"); break;
                }

            } while (opcion != 5);
        }

        private void ConsultarEmpleadosPorCedula()
        {
            

            Console.WriteLine("Ingrese el numero de cedula a consultar: ");
            string cedula = Console.ReadLine();
            Clsempleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Direccion: {empleado.Direccion}. Telefono: {empleado.Telefono}, Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no Encontrado");
            }
        }

        private void ListaEmpleadosOrdenadosPorNombre()
        {
            List<Clsempleado> empleadosOrdenados = empleados.OrderBy(e => e.Cedula).ToList();
            Console.WriteLine("Nombres ordenados alfabeticamente");
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Direccion: {empleado.Direccion}. Telefono: {empleado.Telefono}, Salario: {empleado.Salario}");
            }
        }

        private void CalcularPromedioDeSalario()
        {
            
            if (empleados.Count > 0)
            {
                double promedio = empleados.Average(e => e.Salario);
                Console.WriteLine($"Promedio de Salarios: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados");
            }

        }

        private void CalcularSalarioMasAltoYMasBajo()
        {
            
            if (empleados.Count > 0)
            {

                double SalarioMasAlto = empleados.Max(e => e.Salario);
                double SalarioMasBajo = empleados.Min(e => e.Salario);
                Console.WriteLine($"El salario mas alto es: {SalarioMasAlto}");
                Console.WriteLine($"El Salario mas Bajo es: {SalarioMasBajo}");
                
            }
            else
            {
                Console.WriteLine("No hay empleados inscritos");
            }
        }
     }
}