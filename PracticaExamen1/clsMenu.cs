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
                    case 3: break;
                    case 4: break;
                    case 5: break;
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

            Console.ReadLine();
        }
        public static void SubmenuReportes()
        {

            do
            {
                Console.WriteLine("1. Reporte Estudiantes por Condicion");
                Console.WriteLine("2. Reporte General");
                Console.WriteLine("3. Regresar al menú principal");
                Console.WriteLine("*****************");
                Console.WriteLine("Digite su opción");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Console.WriteLine("Reporte 1"); ; break;
                    case 2: Console.WriteLine("Reporte 2"); ; break;
                    case 3: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción digitada no existe");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 3);
            Console.ReadLine();
        }

    }
}
