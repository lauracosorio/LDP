using System; //Usando una libreria generica

namespace introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola a Todos!");

            //Forma estructurada 


            //Pidiendo datos
            Console.WriteLine("Número uno");
            int numUno = int.Parse(Console.ReadLine()); //se crea una Uvariable entero y el valor que se captura se convierte a entero y Deja ingresar datos
            //Console.WriteLine($"El número es :  {numUno}");
            Console.WriteLine("Número dos");
            int numDos = int.Parse(Console.ReadLine()); //se crea una Uvariable entero y el valor que se captura se convierte a entero y Deja ingresar datos
                                                        // Console.WriteLine($"El número es :  {numDos}");
                                                        //int suma = numUno + numDos;
                                                        // Console.WriteLine($"La suma de {numUno} + {numDos} es {suma}");

            //Forma oriendata a objetos
            //Instanciar la class operaciones (Crear copia de la clase para utilizarla de forma indirecta )

            //Operaciones myOperacion = new Operaciones(); //class objeto(instancia) (= new)sonPalabrasReservadas constructordelaclase(es el mismo nombre de la clase)

            var myOperation = new Operaciones(){
                numberUno = numUno,
                numberDos = numDos,
            };

            //Verificar el valor que tiene almacenado la propiedad

            Console.WriteLine(myOperation.numberUno);

            //Llevar el valor como parametro a un método
            //Llamar el método de la clase mediante tu instancia (objeto)

            myOperation.mostrar();

        }
    }
}
