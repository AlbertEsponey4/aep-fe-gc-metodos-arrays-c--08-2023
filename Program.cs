using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TA21
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Exer1.Execute();
            Console.WriteLine("\n\n");
            Exer2.Execute();
            Console.WriteLine("\n\n");
            Exer3.Execute();
            Console.WriteLine("\n\n");
            Exer4.Execute();
            Console.WriteLine("\n\n");
            Exer5.Execute();
            Console.WriteLine("\n\n");
            Exer6.Execute();
            Console.WriteLine("\n\n");
            Exer7.Execute();
            Console.WriteLine("\n\n");
            Exer8.Execute();
            Console.WriteLine("\n\n");
            Exer9.Execute();
            Console.WriteLine("\n\n");
            Exer10.Execute();
            Console.WriteLine("\n\n");
            Exer11.Execute();
            Console.WriteLine("\n\n");
            Exer12.Execute();
            Console.WriteLine("\n\n");
            Exer13_14.Execute();
            Console.WriteLine("\n\n");
            Exer15.Execute();
            Console.WriteLine("\n\n");
            Exer16.Execute();
            Console.WriteLine("\n\n");


        }
    }

    class Exer1
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("De que figura quieres calcular su area?");
            Console.WriteLine("Escoge una opción: \n1. Circulo \n2. Triangulo\n3. Cuadrado\n");

            string input = Console.ReadLine();

            //si el input es un entero
            if (int.TryParse(input, out int numero))
            {
                switch (numero)
                {
                    case 1:
                        Console.Write("Introudce el radio: ");
                        string radioString = Console.ReadLine();

                        if (double.TryParse(radioString, out double radio))
                            Console.WriteLine($"El area del círculo es: {CalculaAreaCiruclo(radio)}");

                        else
                            Console.WriteLine("Radio no valido");


                        break;
                    case 2:
                        Console.Write("Introduce base: ");
                        string baseString = Console.ReadLine();
                        Console.Write("Introduce altura: ");
                        string alturaString = Console.ReadLine();

                        if (double.TryParse(baseString, out double baseT) && double.TryParse(alturaString, out double altura))
                            Console.WriteLine($"El area del triangulo es: {CalculaAreaTriangulo(baseT, altura)}");

                        else
                            Console.WriteLine("Valores no validos");

                        break;
                    case 3:
                        Console.Write("Introduce lado: ");
                        string ladoString = Console.ReadLine();

                        if (double.TryParse(ladoString, out double lado))
                            Console.WriteLine($"El area del triangulo es: {calculaAreaCuadrado(lado)}");

                        else
                            Console.WriteLine("Lado no valido");

                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }

        public static double CalculaAreaCiruclo(double radio)
        {
                return Math.PI * Math.Pow(radio, 2);
        }

        public static double CalculaAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
        }

        public static double calculaAreaCuadrado(double lado)
        {
            return lado * lado;
        }
    }
    class Exer2
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 2");

            Console.Write("Introduce el valor minimo: ");
            string inputMin = Console.ReadLine();
            Console.Write("Introduce el valor maximo: ");
            string inputMax = Console.ReadLine();
            Console.Write("Cuantos numeros aleatosios quieres generar?");
            string numerosAleatorios = Console.ReadLine();

            if (int.TryParse(inputMin, out int min) && int.TryParse(inputMax, out int max) && int.TryParse(numerosAleatorios, out int numeros) && max >= min)
            {
                Console.WriteLine("Numeros aleatorios generados:");
                for (int i = 0; i < numeros; i++)
                {
                    int numeroAleatorio = GenerarNumeroAleatorio(min, max);
                    Console.WriteLine(numeroAleatorio);
                }
            }
            else
            {
                Console.WriteLine("valores no validos");
            }
        }

        public static int GenerarNumeroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }

    class Exer3
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 3");
            Console.Write("Introduce un número: ");
            string numeroS = Console.ReadLine();

            if (int.TryParse(numeroS, out int numero) && EsPrimo(numero))
                Console.WriteLine($"{numero} es primo");
            else
                Console.WriteLine($"{numero} NO es primo");
        }

        public static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
    class Exer4
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 4");
            Console.Write("Introduce un número: ");
            string numeroStr = Console.ReadLine();

            if (int.TryParse(numeroStr, out int numero))
                Console.WriteLine($"El factorial es: {CalcularFactorial(numero)}");

            else
                Console.WriteLine("Numero no valido");
        }
        //Fucnion recursiva, tratamos el caso base y vamos llamando la misma funcion hasta llegar al caso base.
        public static int CalcularFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalcularFactorial(n - 1);
        }
    }

    class Exer5
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 5");
            Console.Write("Introduce un número entero: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
                Console.WriteLine($"El número binario es: {DecimalABinario(numero)}");
            else
                Console.WriteLine("Numero no valido");
        }

        public static string DecimalABinario(int numero)
        {
            // tengo que inicializar a un array vacio para empezar a concaternar
            string binario = "";

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo + binario;
                numero = numero / 2;
            }
            return binario;
        }
    }

    class Exer6
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 6");
            Console.Write("Introduce un número entero positivo: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
                Console.WriteLine($"numero de cifras: {ContarCifras(numero)}");
            else
                Console.WriteLine("Numero no valido");
        }
        public static int ContarCifras(int numero)
        {
            int cont = 0;
            while (numero > 0)
            {
                numero = numero / 10;
                cont++;
            }
            return cont;
        }
    }

    class Exer7
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 7");

            Console.Write("Introduce la moneda a la que quieres convertir (dolares/yenes/libras): ");
            string moneda = Console.ReadLine();

            
            Console.Write("Introduce la cantidad de euros: ");
            if (int.TryParse(Console.ReadLine(), out int cantidad))
                ConvertirMoneda(cantidad, moneda);
            else
                Console.WriteLine("cantidad no valida");
       
           
            
        }

        public static void ConvertirMoneda(double cantidadEuros, string moneda)
        {
            double valorCambio = 0;

            switch (moneda)
            {
                case "dolares":
                    valorCambio = 1.28611;
                    break;
                case "yenes":
                    valorCambio = 129.852;
                    break;
                case "libras":
                    valorCambio = 0.86;
                    break;
                default:
                    Console.WriteLine("Moneda no válida.");
                    return;
            }

            double cantidadConvertida = cantidadEuros * valorCambio;
            Console.WriteLine($"{cantidadEuros} euros equivalen a {cantidadConvertida} {moneda}.");
        }
    }

    class Exer8
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 8");

            Console.Write("Introduce la longitud del array: ");
            if (int.TryParse(Console.ReadLine(), out int longitud))
            {
                int[] array = new int[longitud];

                for (int i = 0; i < longitud; i++)
                {
                    array[i] = i;
                }

                Console.WriteLine("Contenido del array:");
                foreach (int elemento in array)
                {
                    Console.WriteLine(elemento);
                }
            }
            else
            {
                Console.WriteLine("Longitud no valida");
            }
        }
    }

    class Exer9
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 9");

            Console.Write("Introduce la longitud del array: ");
            if (int.TryParse(Console.ReadLine(), out int longitud))
            {
                int[] array = new int[longitud];

                for (int i = 0; i < longitud; i++)
                {
                    Console.Write($"Introduce el numero de la posición {i}: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        array[i] = numero;
                    }
                    else
                    {
                        Console.WriteLine("no es un numero entero");
                        //retrocedo una posicion el indice para que vuelva a poner un numero correcto
                        i--;
                    }
                }

                Console.WriteLine("Contenido del array:");
                foreach (int elemento in array)
                {
                    Console.WriteLine(elemento);
                }
            }
            else
            {
                Console.WriteLine("Longitud no valida");
            }
        }
    }

    class Exer10
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 10");

            int[] array = new int[11];
            Console.Write("Introduce un numero:");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Tabla de multiplicar:");
                for (int i = 0; i < 11; i++)
                {
                    array[i] = numero * i;
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {array[i]}");
                }
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
        }
    }

    class Exer11
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 11");
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Introduce valor de la posicion {i}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    array[i] = numero;
                }
                else
                {
                    Console.WriteLine("numero no es correcto.");
                    //le resto una posicion para volver a poner el numero de esa posicon
                    i--;
                }
            }

            int suma = 0;
            foreach (int elemento in array)
            {
                suma += elemento;
            }

            Console.WriteLine($"Todos los elementos sumados: {suma}");
        }
    }

    class Exer12
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 12");
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Introduce valor de la posicion {i}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    array[i] = numero;
                }
                else
                {
                    Console.WriteLine("numero no es correcto.");
                    //le resto una posicion para volver a poner el numero de esa posicon
                    i--;
                }
            }

            int suma = 0;
            foreach (int elemento in array)
            {
                suma += elemento;
            }

            Console.WriteLine($"Media de todos los valores del array: {suma/10}");
        }
    }
    class Exer13_14
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 13");

            Console.Write("Introduce la longitud del array: ");
            if (int.TryParse(Console.ReadLine(), out int longitud))
            {
                int[] array = new int[longitud];
                Random random = new Random();

                for (int i = 0; i < longitud; i++)
                {
                    array[i] = random.Next(1, 10 + 1);
                }

                Console.WriteLine("Contenido del array:");
                foreach (int elemento in array)
                {
                    Console.WriteLine(elemento);
                }

                //exer 14

                Console.Write("Introduce el numero que quieres buscar en el array");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    bool encontrado = false;
                    foreach (int elemento in array)
                    {
                        if (elemento == numero)
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        Console.WriteLine($"El número {numero} existe en el array.");
                    }
                    else
                    {
                        Console.WriteLine($"El número {numero} no existe en el array.");
                    }
                }
                else
                {
                    Console.WriteLine("Numero no válido.");
                }
            }
            else
            {
                Console.WriteLine("Longitud no valida.");
            }
        }
    }

    class Exer15
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 15");
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] arrayInvertido = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayInvertido[i] = array[array.Length - (i + 1)];
            }

            Console.WriteLine("array invertido:");
            foreach (int elemento in arrayInvertido)
            {
                Console.WriteLine(elemento);
            }
        }
    }

    class Exer16
    {
        public static void Execute()
        {
            Console.WriteLine("Ejercicio 16");

            int[] array = {3, 4, 6, 4 ,3};

            bool capicua = true;
            //recorro el array hasta la mitad
            for (int i = 0; i < array.Length / 2; i++)
            {   
                if (array[i] != array[array.Length - (i + 1)])
                {
                    capicua = false;
                    break;
                }
            }

            if (capicua)
            {
                Console.WriteLine("El array es capicua.");
            }
            else
            {
                Console.WriteLine("El array no es capicua.");
            }
        }
    }
}