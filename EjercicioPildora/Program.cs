using System;

namespace UsoWhile
{
    class Program // El flujo de ejecucción es de Arriba hacia abajo (salvo que haya un condicional o un b)
    {
        static void Main(string[] args) 
        {
            Random numero= new Random();

            int aleatorio = numero.Next(0,100);

            int minumero = 101; // variable es un entero

            int intentos = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");

            while (aleatorio != minumero)
            {
                intentos++;

                try
                
                { 
                minumero=int.Parse(Console.ReadLine()); //Aquì es donde el programa cae

                }
                catch(FormatException ex)
                {
                    Console.WriteLine("No haz introducido un número válido.");
                    minumero = 0;
                }

                if (minumero > aleatorio) Console.WriteLine("El número es más bajo");

                if (minumero < aleatorio) Console.WriteLine("El número es más alto");
            }

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta línea el código del programa continuaría");
        }
    }
}