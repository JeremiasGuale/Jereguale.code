class Program
{
        static void Main(string[] args)
        {
            // Creamos una pizza Margherita básica
            Pizza pizza = new PizzaMargherita();

            // Agregamos ingredientes adicionales utilizando los decoradores
            pizza = new QuesoExtra(pizza);
            pizza = new Pepperoni(pizza);

            // Obtenemos la descripción y el costo de la pizza final
            Console.WriteLine("Descripción: " + pizza.Descripcion);
            Console.WriteLine("Costo: $" + pizza.Costo());

            // Output:
            // Descripción: Pizza Margherita, Queso Extra, Pepperoni
            // Costo: $9.47
        }
    }

//En este ejemplo, creamos una pizza Margherita básica y luego utilizamos 
//los decoradores QuesoExtra y Pepperoni para agregar ingredientes adicionales a la pizza. Al final, obtenemos la descripción y el costo de la pizza final, que incluye todos los ingredientes adicionales.

//El patrón Decorator nos permite agregar y combinar funcionalidades de manera flexible. Podemos agregar más decoradores o modificar la secuencia de decoradores sin modificar la estructura de la clase base Pizza. Esto facilita la extens






