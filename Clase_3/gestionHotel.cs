using System;

namespace Clase_3
{
    class gestionHotel
    {

        //Propiedades
        public string habitacion { get; set; }
        public int huesped { get; set; }

        int Dias;
        public int dias
        {
            get { return Dias; }
            set
            {
                if (value >= 1)
                {
                    Dias = value;
                }
                else
                {
                    Console.WriteLine("Cantidad días no valida, debe seleccionar mínimo un número");
                }
            }
        }

        //Métodos
        public int valorEstadia(int dias, int huesped)
        {
            int TINDIVIDUAL = 2500;
            int TDOBLE = 4600;
            int TFAMILIAR = 5200;

            int cobro = 0;

            if (huesped == 1)
            {
                cobro = dias * TINDIVIDUAL;
            }
            else if (huesped == 2)
            {
                cobro = dias * TDOBLE;
            }
            else if (huesped >= 3)
            {
                cobro = dias * TFAMILIAR;
            }
            return cobro;
        }

        public void mostrar()
        {

            int IVA = 19;
            int precioSinIva = valorEstadia(dias, huesped);
            int precioConIva = 0;
            precioConIva = (precioSinIva * IVA) / 100 + precioSinIva;

            Console.WriteLine(precioConIva);
        }

    }
}
