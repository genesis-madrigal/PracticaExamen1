using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class clsMenu
    {
        //Atributo
        static int opcion = 0; //variable de tipo global

        public static void Desplegar()
        {
            Console.Clear();
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
                //opcion = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out opcion); //no se cae si se meten letras
                Console.Clear();

                switch (opcion)
                {
                    case 1: clsEstudiante.Inicializar(); break;
                    case 2: clsEstudiante.Agregar(); break;
                    case 3: clsEstudiante.Consultar(clsEstudiante.SolicitarCedula()); break;
                    case 4: clsEstudiante.Modificar(clsEstudiante.SolicitarCedula());  break;
                    case 5: clsEstudiante.Eliminar(clsEstudiante.SolicitarCedula());  break;
                    case 6: Console.Clear();  SubmenuReportes(); break;
                    case 7: break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 7);
        }
        public static void SubmenuReportes()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("1. Reporte Estudiantes por Condicion");
                Console.WriteLine("2. Reporte General");
                Console.WriteLine("3. Regresar al menú principal");
                Console.WriteLine("*****************");
                Console.WriteLine("Digite su opción");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: clsMenu.MenuCondiciones(); break;
                    case 2: clsEstudiante.ReporteGeneral(); break;
                    case 3: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 3);
        }

        public static void MenuCondiciones()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("1. Aprobado");
                Console.WriteLine("2. Aplazado");
                Console.WriteLine("3. Reprobado");
                Console.WriteLine("4. Regresar al menú anterior");
                Console.WriteLine("*****************");

                Console.WriteLine("Digite el número correspondiente a la condición a consultar: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: clsEstudiante.ReporteCondicion("APROBADO"); break;
                    case 2: clsEstudiante.ReporteCondicion("APLAZADO"); break;
                    case 3: clsEstudiante.ReporteCondicion("REPROBADO"); break;
                    case 4: break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);

        }
    }
}
