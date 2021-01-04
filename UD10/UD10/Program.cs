using System;

namespace UD10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Eric Pastor", 1000);

            string opcion = "";
            string opcion2 = "";

            string nombre = "";
            int edad = 0;
            char sexo = ' ';
            float peso = 0;
            float altura = 0;

            Console.WriteLine("Escoge una opcion entre el 1 y el 9");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine(cuenta1.ToString());
                    Console.WriteLine("Desea ingresar o retirar dinero? (1 ingresar 2 retirar)");
                    opcion2 = Console.ReadLine();

                    if(opcion2 == "1")
                    {
                        Console.WriteLine("Cantidad a ingresar?");
                        cuenta1.Ingresar(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (opcion2 == "2")
                    {
                        Console.WriteLine("Cantidad a retirar?");
                        cuenta1.Retirar(Convert.ToDouble(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine("Opcion incorrecta");
                    }
                    Console.WriteLine(cuenta1.ToString());

                    break;
                case "2":
                    Console.WriteLine("Dame un nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Dame una edad");
                    edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dame un sexo (H o M)");
                    sexo = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Dame un peso");
                    peso = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Dame una altura");
                    altura = Convert.ToSingle(Console.ReadLine());

                    Persona persona1 = new Persona(nombre,edad,sexo,peso,altura);
                    Persona persona2 = new Persona(nombre, edad, sexo);
                    Persona persona3 = new Persona();
                    persona3.Nombre = "Eric";
                    persona3.Edad = 27;
                    persona3.Sexo = 'H';
                    persona3.Peso = 55;
                    persona3.Altura = 1.69f;

                    persona1.mostrarIMC();
                    persona2.mostrarIMC();
                    persona3.mostrarIMC();
                    Console.WriteLine();

                    if (persona1.esMayorDeEdad()) Console.WriteLine("Es mayor de edad");
                    else Console.WriteLine("Es menor de edad");

                    if (persona2.esMayorDeEdad()) Console.WriteLine("Es mayor de edad");
                    else Console.WriteLine("Es menor de edad");

                    if (persona3.esMayorDeEdad()) Console.WriteLine("Es mayor de edad");
                    else Console.WriteLine("Es menor de edad");

                    Console.WriteLine();
                    Console.WriteLine(persona1.ToString());
                    Console.WriteLine(persona2.ToString());
                    Console.WriteLine(persona3.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
