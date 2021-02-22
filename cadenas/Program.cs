using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FUNCIONES_DE_CADENA
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            byte K;
            Console.Write("DIGITE SU NOMBRE : "); NOM = Console.ReadLine();
            Console.WriteLine("LONGITUD : " + NOM.Length);
            Console.WriteLine("ESTA DENTRO : " + NOM.Contains("ARIEL"));
            Console.WriteLine("REEMPLAZO VOCAL A: " + NOM.Replace("A", "X"));
            Console.WriteLine("EN MINUSCULAS : " + NOM.ToLower());
            Console.WriteLine("EN MAYÚSCULAS : " + NOM.ToUpper());
            Console.WriteLine("REMOVER 4 LETRAS : " + NOM.Remove(3, 4));
            Console.WriteLine("EXTRAER 4 LETRAS : " + NOM.Substring(3, 4));
            Console.WriteLine("IZQUIERDA 4 LETRAS : " + Left(NOM, 4));
            Console.WriteLine("DERECHA 4 LETRAS : " + Right(NOM, 4));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("DESDE LA IZQUIERDA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Left(NOM, K));
            }
            Console.WriteLine();
            Console.WriteLine("DESDE LA DERECHA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Right(NOM, K));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
    }
}