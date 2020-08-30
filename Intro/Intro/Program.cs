using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Escribir y leer en consola

            Console.WriteLine("¡Hola mundo!");

            Console.WriteLine("Dime un número.");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Has escrito el número " + n);

            // 2- Estructuras de control: if, for, while
            // Son exactamente iguales que en java

            int i, j;
            for (i = 0; i < 0; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 3- Funciones
            // Son exactamente iguales que en java

            Console.WriteLine("La suma de 5 y 7 es " + Suma2Numero(5, 7));

            // 4- Arrays
            // Iguales que en Java

            int[] array5 = { 1, 2, 3, 4, 5 };
            string[] arrayCadenas = new string[3];

            int tam = array5.Length;

            // 5- Cadenas
            // Son un poco distintas
            // En C# se comparan con ==
            // En C# se accede a los caracteres de una cadena con []

            string cadena = "patata";

            if (cadena == "patata")
            {
                for (i = 0; i < cadena.Length; i++)
                {
                    Console.WriteLine(cadena[i]);
                }
            }

            // Las cadenas tienen muchas funciones, gual que en java

            //cadena.Substring: 
            // tiene 2 parámetros: posición inicial y número de caracteres
            //cadena.IndexOf
            //cadena.Split
            //cadena.Replace
            //cadena.Remove
            //cadena.Insert

            // 6- Listas

            List<int> listaEnteros = new List<int>() { 1, 2, 3 };
            listaEnteros.Add(4);

            for (i = 0; i < listaEnteros.Count; i++)
            {
                Console.WriteLine(listaEnteros[i]);
            }

            //listaEnteros.Insert añadir en una posición que no sea al final
            //listaEnteros.RemoveAt quita el elemento de un posción
            //ListaEnteros.Remove quita el elemento
            //listaEnteros.Sort
            //listaEnteros.Reverse
            //listaEnteros.Max .Min
            //listaEnteros.AddRange como el addAll en Java
            //listaEnteros.Average calcula la media


            // 7- Arrays multidimensionales
            int[,] arrayMulti = new int[4, 5];

            for(i = 0; i < arrayMulti.GetLength(0); i++) // primera dimensión = GetLength(0)
            {
                for(j = 0; j < arrayMulti.GetLength(1); j++) // segunda dimensión
                {
                    Console.Write(arrayMulti[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 8- Ficheros

            // Escribir en un fichero
            StreamWriter sw = new StreamWriter("fichero.txt");

            sw.WriteLine("hola");
            sw.WriteLine("caracola");
            sw.Close();

            // Leer de un fichero
            StreamReader sr = new StreamReader("fichero.txt");
            
            while(!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Console.WriteLine(linea);
            }
            sr.Close();

            // Escribir en un fichero binario
            FileStream fs = new FileStream("binario.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(6);
            bw.Write(10.9);
            bw.Write("patata");

            bw.Close();
            fs.Close();

            // Leer de un fichero binario
            FileStream fs2 = new FileStream("binario.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs2);

            int entero = br.ReadInt32();
            double doble = br.ReadDouble();
            string cadena2 = br.ReadString();

            br.Close();
            fs2.Close();

            // si quisiéramos leer datos hasta el final en un binario
            // while(fs2.Position < fs2.Length)
            // { }

            // 9- Clases

            Coche c = new Coche("3495BCD", "Seat", "Ibiza", false, 5, 2500);

            Console.WriteLine(c.Matricula);

            c.Matricula = "5847MKL";

            Console.WriteLine(c);

            // Ejemplo de autocreación de clase

            string isbn = "3245-45-245-42";
            string titulo = "El Quijote";

            Libro l = new Libro(isbn, titulo);

            // Para que no se cierre la consola
            Console.ReadKey();

        }

        public static int Suma2Numero(int a, int b)
        {
            return a + b;
        }
    }
}
