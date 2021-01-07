using System;

namespace UD10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Eric Pastor", 1000);
            Object[] array_electro = new Object[10];
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
                case "3":
                    int longitud_pass = 0;
                    
                    Console.WriteLine("Dame una longitud para la array de passwords");
                    Password[] array_password = new Password[Convert.ToInt32(Console.ReadLine())];
                    bool[] array_fuerte = new bool[array_password.Length];
                    Console.WriteLine("Dame una longitud para los passwords de la array");
                    longitud_pass = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < array_password.Length; i++)
                    {
                        array_password[i] = new Password(longitud_pass);
                        array_fuerte[i] = array_password[i].esFuerte();

                        array_password[i].MostrarContraseña();
                        Console.WriteLine(array_fuerte[i]);
                    }

                    break;
                case "4":
                    array_electro[1] = new Lavadora(40, new Electrodomestico(50, "blanco", 'B', 10));
                    array_electro[2] = new Television(50, true, new Electrodomestico(50, "rojo", 'A', 60));
                    array_electro[3] = new Electrodomestico(40, "azul", 'E', 40);
                    array_electro[4] = new Lavadora(40, new Electrodomestico(100, "negro", 'C', 60));
                    array_electro[5] = new Television(80, false, new Electrodomestico(50, "gris", 'B', 10));
                    array_electro[6] = new Electrodomestico(90, "blanco", 'D', 80);
                    array_electro[7] = new Lavadora(10, new Electrodomestico(60, "blanco", 'F', 50));
                    array_electro[8] = new Television(40, true, new Electrodomestico(10, "blanco", 'A', 100));
                    array_electro[9] = new Electrodomestico(70, "rojo", 'A', 40);
                    array_electro[0] = new Lavadora(40, new Electrodomestico(10, "blanco", 'B', 10));


                    double totalLavadoras = 0;
                    double totalTelevisores = 0;
                    double totalElectrodomesticos = 0;

                    for (int i = 0; i < array_electro.Length; i++)
                    {
                        if(array_electro[i].GetType().Name == "Lavadora")
                        {
                            Lavadora lava = (Lavadora)array_electro[i];
                            lava.precioFinal();
                            totalLavadoras += lava.Precio_base;
                            totalElectrodomesticos += lava.Precio_base;
                        }

                        else if (array_electro[i].GetType().Name == "Television")
                        {
                            Television tele = (Television)array_electro[i];
                            tele.precioFinal();
                            totalTelevisores += tele.Precio_base;
                            totalElectrodomesticos += tele.Precio_base;
                        }
                        else
                        {
                            Electrodomestico electro = (Electrodomestico)array_electro[i];
                            electro.precioFinal();
                            totalElectrodomesticos += electro.Precio_base;
                        }
                    }
                    Console.WriteLine("El precio total de los televisores es {0}, el de las lavadoras es {1} y el de todos los eletrodomesticos es {2}", totalTelevisores, totalLavadoras, totalElectrodomesticos);                  
                    break;
                default:
                    break;
            }
        }
    }
}
