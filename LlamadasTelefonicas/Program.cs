using System;

namespace LlamadasTelefonicas
{
    class Program
    {
        static void Main()
        {
            int tipo;
            int duracion;
            do
            {

                Console.WriteLine("Introduzca tipo de llamada  \n 1. local" +
                    "\n 2. nacional \n 3. Internacional ");
                //Conversion de cadena a entero
                 tipo = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca la duración de la llamada");
                 duracion = int.Parse(Console.ReadLine());

                if (duracion > 0)
                {
                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("¿Cuántas llamadas realizaste");
                            int n = int.Parse(Console.ReadLine());
                            if (n < 51)
                            {
                                Console.WriteLine("No hay adeudo");
                            }
                            else
                            {
                                float costo = (n - 50) * .6f;
                                Console.WriteLine("El adeudo es: {0} ", costo);
                            }

                            break;

                        case 2:
                            if (duracion < 3)
                            {
                                Console.WriteLine("El adeudo es: $1.20 ");
                            }
                            else
                            {
                                float costo = ((duracion - 3) * .48f) + 1.2f;
                                Console.WriteLine("El adeudo es: {0}", costo);
                            }
                            break;

                        case 3:
                            if (duracion < 3)
                            {
                                Console.WriteLine("Debes $5.02");
                            }
                            else
                            {
                                float costo = ((duracion - 3) * 3.03f) + 5.02f;
                                Console.WriteLine("El adeudo es: ${0}", costo);
                            }


                            break;
                        default:
                            tipo = 4;
                            break;                         

                    }
                }

            } while ( duracion > 0 && tipo != 4  );
        }
    }
}
