namespace HolaMundo
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ivan Castillo");
            // Tipos de datos primitivos//
            int edad = 26;
            Console.WriteLine($"Tu edad es: {edad}");
            string nombre = "Ivan castillo ";
            Console.WriteLine($"Tu nombre es: {nombre}");
            Console.WriteLine($"Tu nombre es: {nombre.ToUpper()}");
            Console.WriteLine($"Tu nombre es: {nombre.ToLower()}");
            Console.WriteLine($"Tu nombre tiene: {nombre.Length}letra");

            // variables con doble precision //

            Double precio = 39.8;
            Console.WriteLine($"El precio es de: ${precio}");
            Console.WriteLine($"El precio es de: ${precio++}");
            Console.WriteLine($"El precio es de: ${++precio}");

            // valores logicos //
            Boolean IsSingle = true;

        }   

    }
}