using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMenu.Desplegar();
            Console.Read();
        }

           /* int opcion = 0;

            int cantidad = 2;

            string[] cedulaEstudiante = new string[cantidad];
            string[] nombreEstudiante = new string[cantidad];
            double[] promedio = new double[cantidad];
            string[] condicion = new string[cantidad];

            do
            {

                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Consultar Estudiantes");
                Console.WriteLine("4. Modificar Estudiantes");
                Console.WriteLine("5. Eliminar Estudiantes");
                Console.WriteLine("6. Submenú Reportes");
                Console.WriteLine("7. Salir");
                Console.WriteLine("*****************");
                Console.WriteLine("Digite su opción");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        
                        

                        break;

                    case 2: IncluirEstudiantes(cantidad, cedulaEstudiante, nombreEstudiante, promedio, condicion); break;
                    case 3: ConsultarEstudiantes(cantidad, cedulaEstudiante, nombreEstudiante, promedio, condicion); break;
                    case 4: ModificarEstudiantes(); break;
                    case 5: EliminarEstudiantes(); break;
                    case 6: SubmenuReportes(cantidad, cedulaEstudiante, nombreEstudiante, promedio, condicion); break;
                    case 7:
                        Console.WriteLine("Pulse cualquier tecla para cerrar el programa");


                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 7);

            Console.ReadLine();
        }

        //Métodos
      
        static void IncluirEstudiantes(int cantidad, string[] cedulaEstudiante, string[] nombreEstudiante, double[] promedio, string[] condicion)
        {
            

            for (int i = 0; i < cantidad; i++)
            {
                 

                Console.Clear(); //limpia la pantalla
                Console.Write("Digite la cédula del estudiante: ");
                cedulaEstudiante[i] = Console.ReadLine();

                Console.Write("Digite el nombre del estudiante: ");
                nombreEstudiante[i] = Console.ReadLine();

                Console.WriteLine("Digite el promedio del estudiante: ");
                promedio[i] = double.Parse(Console.ReadLine());

                if (promedio[i] >= 70)
                {
                    condicion[i] = "APROBADO";
                }

                else if (promedio[i] < 70 && promedio[i] >= 60)
                {
                    condicion[i] = "APLAZADO";
                }

                else
                {
                    condicion[i] = "REPROBADO";
                }
                Console.WriteLine($" \nLa condición del estudiante es: {condicion[i]}.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void ConsultarEstudiantes(int cantidad, string[] cedulaEstudiante, string[] nombreEstudiante, double[] promedio, string[] condicion)
        {
            Console.WriteLine("Ingrese el número de cédula del estudiante a consultar: ");
            string cedulaBuscar = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (cedulaEstudiante[i] == cedulaBuscar)
                {
                    Console.WriteLine($" \nCedula: {cedulaEstudiante[i]}.");
                    Console.WriteLine($" \nNombre: {nombreEstudiante[i]}.");
                    Console.WriteLine($" \nPromedio: {promedio[i]}.");
                    Console.WriteLine($" \nCondición: {condicion[i]}.");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                }
                else
                {
                    Console.WriteLine("No se encontró la cédula ingresada");
                    Console.Clear();
                }
                
            }

        }


        static void ModificarEstudiantes()
        {
            Console.WriteLine("Ingrese el número de cédula del estudiante a modificar: ");
        }


        static void EliminarEstudiantes()
        {
            Console.WriteLine("Ingrese el número de cédula del estudiante a eliminar: ");

        }


        static void SubmenuReportes(int cantidad, string[] cedulaEstudiante, string[] nombreEstudiante, double[] promedio, string[] condicion)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Reporte Estudiantes por Condicion");
                Console.WriteLine("2. Reporte todos los datos");
                Console.WriteLine("3. Salir");
                Console.WriteLine("*****************");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: ReporteEstudiantesCondicion(cantidad, cedulaEstudiante, nombreEstudiante, promedio, condicion); break;
                    case 2: ReporteTodosDatos(); break;
                    case 3:
                        Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 3);
            Console.ReadLine();
        } 


        static void ReporteEstudiantesCondicion(int cantidad, string[] cedulaEstudiante, string[] nombreEstudiante, double[] promedio, string[] condicion)
        {
            int opcion;

            Console.WriteLine("1. Aprobado");
            Console.WriteLine("2. Reprobado");
            Console.WriteLine("3. Aplazado");
            Console.WriteLine("*****************");

            Console.WriteLine("Digite la condición a consultar: \"");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (condicion[i] == "APROBADO")
                        {

                        }
                    }
                   
                    break;
                case 2: ReporteTodosDatos(); break;
                case 3:
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opción digitada no existe");
                    Console.ReadLine();
                    break;
            }
        }

        static void ReporteTodosDatos()
        {
            Console.WriteLine("Ingrese el número de cédula del estudiante a consultar: ");


        }*/

      }
   }