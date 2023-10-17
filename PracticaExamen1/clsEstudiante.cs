using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class clsEstudiante
    {
        //atributos
        static int cantidad = 4;

        static public string[] cedulaEstudiante = new string[cantidad]; //blancos

        static public string[] nombreEstudiante = new string[cantidad]; //blancos

        static public int[] promedio = new int[cantidad]; //0

        static public string[] condicion = new string[cantidad]; //blancos


        //metodos
        static public void Inicializar()
        {

            cedulaEstudiante = Enumerable.Repeat("", cantidad).ToArray(); //crea espacios en blanco y luego los hace un arreglo y asigna a cedula
            nombreEstudiante = Enumerable.Repeat("", cantidad).ToArray();
            promedio = Enumerable.Repeat(0, cantidad).ToArray();
            condicion = Enumerable.Repeat("", cantidad).ToArray();

            Console.WriteLine("Sistema ha sido inicializado");

        }

        public static string SolicitarCedula()
        {
            Console.WriteLine("Digite la cédula: ");
            string ced = Console.ReadLine();
            return ced;
        }

        public static void Agregar()
        {
            
            
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear(); //limpia la pantalla
                Console.Write("Digite la cédula del estudiante {0}: ", cont);
                cedulaEstudiante[i] = Console.ReadLine();

                Console.Write("Digite el nombre del estudiante {0}: ", cont);
                nombreEstudiante[i] = Console.ReadLine();

                Console.Write("Digite el promedio del estudiante {0}: ", cont);
                int.TryParse(Console.ReadLine(), out promedio[i]);
                cont++;

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

            }
            Console.Clear();
        }

        public static void Consultar(string ced)
            {
            bool encontrado = false;

            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedulaEstudiante[i]))
                {
                    Console.WriteLine($"Nombre: {nombreEstudiante[i]}. Nota: {promedio[i]}.");
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false) //(!encontrado) es lo mismo
            {
                Console.WriteLine("Estudiante no existe");
            }
        }

        public static void Modificar(string ced)
        {
            Console.Clear();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedulaEstudiante[i]))
                {
                    Console.Write("Digite el nombre del estudiante: ");
                    nombreEstudiante[i] = Console.ReadLine();

                    Console.Write("Digite el promedio del estudiante: ");
                    int.TryParse(Console.ReadLine(), out promedio[i]);

                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false) //(!encontrado) es lo mismo
            {
                Console.WriteLine("Estudiante no existe");
            }
        }

        public static void Eliminar(string ced)
        {
            Console.Clear();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedulaEstudiante[i]))
                {
                    nombreEstudiante[i] = "";

                    promedio[i] = 0;

                    condicion[i] = "";

                    Console.WriteLine("El estudiante ha sido eliminado correctamente.");

                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false) //(!encontrado) es lo mismo
            {
                Console.WriteLine("Estudiante no existe");
            }
        }

        public static void ReporteCondicion(string opcion)
        {
            int cont = 1;

            Console.Clear();
            Console.WriteLine("Reporte por condición del estudiante: ");

            Console.WriteLine("       Estudiante          Cédula             Nombre            Promedio           Condición      ");

            for (int i = 0; i < cantidad; i++)
            {
                if (opcion.Equals(condicion[i]))
                {
                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($"          {cont}                {cedulaEstudiante[i]}                 {nombreEstudiante[i]}                  {promedio[i]}                 {condicion[i]} ");


                    cont++;
                }
            }

            Console.WriteLine("< PULSE CUALQUIER TECLA PARA VOLVER AL SUBMENÚ >");
            Console.ReadLine();
            Console.Clear();
        }

            

        public static void ReporteGeneral()
        {
            int cont = 1;

            Console.Clear();
            Console.WriteLine("Reporte general de los datos: ");
            Console.WriteLine("       Estudiante          Cédula             Nombre            Promedio           Condición      ");


            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine("===============================================================================================");
                Console.WriteLine($"          {cont}                {cedulaEstudiante[i]}                 {nombreEstudiante[i]}                  {promedio[i]}                 {condicion[i]} ");


                cont++;
            }
            Console.WriteLine("< PULSE CUALQUIER TECLA PARA VOLVER AL SUBMENÚ >");
            Console.ReadLine();
            Console.Clear();
        }
        
    }
}
