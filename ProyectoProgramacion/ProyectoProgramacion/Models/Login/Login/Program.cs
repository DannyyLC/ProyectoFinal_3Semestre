using System.Globalization;

public class login
{
    private static string usuario = "Juan";
    private static string contra = "contrasena";
    public bool verifica (string username, string password)
    {
        if (username == null || password == null)
        {
            throw new ArgumentNullException("Campos no valida, favor de insertar lo que se indica");
        }
        else if (username == usuario && password == contra)
        {
            return true;
        }
        else { return false; }        
    }
}

public class Program
{
    public static void Main()
    {
        login persona1 = new login();
        string username, password;
        bool band = false;

        while (band == false)
        {
            Console.WriteLine("Inserte su nombre de usuario: ");
            username = Console.ReadLine();
            Console.WriteLine("Inserte su Contraseña: ");
            password = Console.ReadLine();
            
            band = persona1.verifica (username, password);

            if (band == false)
            {
                Console.WriteLine("Usuario o contraseña incorrecto");             
            }
        }
    }
}