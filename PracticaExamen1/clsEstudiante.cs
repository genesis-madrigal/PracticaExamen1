using System;
using System.Collections.Generic;
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
        static int cantidad = 10;

        static public string[] cedulaEstudiante = new string[cantidad]; //blancos

        static public string[] nombreEstudiante = new string[cantidad]; //blancos

        static public int[] promedio = new int[cantidad]; //0


        //metodos
        static public void Inicializar()
        {

            cedulaEstudiante = Enumerable.Repeat("", cantidad).ToArray(); //crea espacios en blanco y luego los hace un arreglo y asigna a cedula
            nombreEstudiante = Enumerable.Repeat("", cantidad).ToArray();
            promedio = Enumerable.Repeat(0, cantidad).ToArray();

            Console.WriteLine("Sistema ha sido inicializado");

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

            }
        }

        public static void Consultar()
            {

            Console.WriteLine("Digite la cédula a consultar: ");
            string ced = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedulaEstudiante[i]))
                {
                    Console.WriteLine($"Nombre: {nombreEstudiante[i]} y la nota {promedio[i]}");
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false) //(!encontrado) es lo mismo
            {
                Console.WriteLine("Estudiante no existe");
            }
        }

        
    }
}
