using System;

namespace Clase_4
{
    class gestionCarro
    {
        public double Kilometro { get; set; }
        public double tiempo { get; set; }
        public string placa { get; set; }

        //Métodos
        public double velocidad(double Kilometro, double tiempo) {
            double vel = Kilometro / tiempo;

            return vel;
         }

         public void mostrar(){
             double distancia = velocidad(Kilometro,tiempo);

             Console.WriteLine($"La velocidad obtenida por el carro de placa {placa} es de {distancia} "  );
         }
    }


}