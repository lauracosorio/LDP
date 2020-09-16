using System;

namespace introduction
{
    class Operaciones
    {
        //Atributos (Propiedades)
        public int numberUno { get; set; }
        //public- modificador de acceso (nivel de acceso de un atributo), tipo de dato, nombre propiedad o nombre del atributo, métodos get y set (para que la variable sepa por dónde recibe el valor (set) y poder entregar el valor (get)) 

        public int numberDos { get; set; }

        //Métodos (Funciones)
        // public void nuestraSuma( int n1, int n2)
        //     //modificador de acceso,  tipo retorno,  nombre método (parámetros o args)
        //     {
        //         int suma = n1 + n2;
        //         Console.WriteLine($"La suma de {n1} + {n2} es {suma}");
        //     }

        //Separar responsabilidades en los métodos
        public int calcular(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        public void mostrar()
        {
            Console.WriteLine($"La suma de {numberUno} + {numberDos} es {calcular(numberUno, numberDos)}");
        }
    }

}