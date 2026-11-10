using System;
public class program
{
    private static string email;
    private static string clave;
    private static string usuario;

    public static void Main(string[] args)
    {
        /*Un sistema informático debe conectarse a una base de datos. La conexión puede fallar
         * por credenciales incorrectas o por el servidor caído. El sistema debe reintentar la
         * conexión hasta que se logre o hasta agotar un máximo de 3 intentos.*/


        string usuariocorrecto = "soporteDB";
        string contraseñacorrecta = " Sistemas2025";
        int intentos = 0;
        do
        {
            Console.WriteLine(" ingrese su usuario");
            usuario = Console.ReadLine();

            Console.WriteLine(" ingrese su clave");
            clave = Console.ReadLine();

            if ( usuario == usuariocorrecto && clave == contraseñacorrecta)
            {
                Console.WriteLine("Conexión establecida con la base de datos.");

                break;
            }
            else
            {
                intentos++;
                Console.WriteLine(" usuario o clave incorrectos!!");
                Console.WriteLine("intentos restantes: " + (3 - intentos));
            }
            if (intentos == 3)
            {
                Console.WriteLine("Error de autenticación. Intento X de 3 - por favor, vuelva a intentarlo nuevamente ");

            }

        } while (intentos < 3);
    }
}
