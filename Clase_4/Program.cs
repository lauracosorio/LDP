using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Ingrese la cantidad de Km");
            double Km = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas gastadas en el recorrido");
            double time = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la marca del carro");
            // string marca = Console.ReadLine();
            // Console.WriteLine("Ingrese el modelo del carro");
            // string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la placa del carro");
            string plate = Console.ReadLine();

            //Instanciar 

            var carro = new gestionCarro()
            {
                Kilometro = Km,
                tiempo = time,
                placa = plate,
            };

            carro.mostrar();
        }
    }
}
