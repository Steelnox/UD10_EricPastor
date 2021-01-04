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
                default:
                    break;
            }
        }
    }
}
