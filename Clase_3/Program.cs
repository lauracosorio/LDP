using System;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Cantidad de Huespedes");
            int huesped = int.Parse(Console.ReadLine());

            Console.WriteLine("Días de estadia");
            int cant_dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre Habitación");
            string nom_hab = Console.ReadLine();


            //Instanciar

            var hotel = new gestionHotel()
            {
                habitacion = nom_hab,
                huesped = huesped,
                dias = cant_dias
            };

            hotel.mostrar();
        }
    }
}
