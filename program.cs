public class Helloword
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. informacion academica");
        Console.WriteLine("2. Mostrar fecha");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Seleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine(" ingrese su nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("ingrese su edad: "); 
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese su genero F/M");
                string gender = Console.ReadLine();

                Console.WriteLine("ingrese su facultad");
                string faculty = Console.ReadLine();

                Console.WriteLine(" ingrese su programa academico");
                string program = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine(("La Fecha actual es:") + DateTime.Now);
                break;
            case 3:
                Console.WriteLine("programa Finalizado!!!");
                break;
            default:
                Console.WriteLine("¡Opcion no valida!");
                break;
        }
    }
}



