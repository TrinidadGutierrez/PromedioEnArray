using System;

/*Ingresar 5 números en un array y calcular el promedio de todos
 * en otra variable llamada “promedio”.*/
using System.Diagnostics;

namespace PromedioEnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = new int[5];// new [tipo][longitud];
                       
            int numeros = 5;
            int[] num;
            int suma = 0;
            num = new int[numeros];
            for (int i = 0; i < numeros; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                Debug.WriteLine(num[i]);
                suma = suma + num[i];
            }
            Debug.WriteLine("El promedio es: " + suma / numeros);
        }
    }
}
