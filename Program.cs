
//LICENSE
// By Eduardo Tejada
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la calculadora");

        while (true)
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            string option = Console.ReadLine();

            if (option == "5")
            {
                Console.WriteLine("OK Saliendo...");
                break;
            }

            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (option)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: ha oucrrido un error no se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}

