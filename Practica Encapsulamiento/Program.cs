using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practica_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "José García";
            contactoUno.Direccion = "Veracruz 510";
            contactoUno.CorreoElectronico = "jgarcia@gmail.com";
            contactoUno.TelefonoCasa = "4131605";
            contactoUno.TelefonoCelular = "1039";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Dirección: " + contactoUno.Direccion);
            Console.WriteLine("Correo: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Telefono: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();
        }

    }
}
