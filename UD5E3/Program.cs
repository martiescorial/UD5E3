using System;

namespace UD5E3
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Introduce un numero";
            int numero = Convert.ToInt32(texto);
            //Ejecutamos la funcion, como devuelve true o false, se puede colocar en un if"
            if (esPrimo(numero))
            {
                Console.WriteLine("El numero " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no es primo");
            }
        }
        public static bool esPrimo(int numero)
        {

            //Un numero menor o igual que 1, no es primo.
            if (numero <= 1)
            {
                return false;
            }

            //Declaramos esta variable aqui ya que despues es usada"
            int cont = 0;
            for (int divisor = (int)Math.Sqrt(numero); divisor > 1; divisor--)
            {
                //contabilizados los divisibles"
                if (numero % divisor == 0)
                {
                    cont += 1;
                }
            }
            //Según el numero de divisibles es o no primo"
            if (cont >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
