using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private float peso;
        private float altura;

        private const int pesoMinimo = 20;
        private const int pesoMaximo = 25;

        public Persona()
        {
            nombre = "";
            edad = 0;
            sexo = 'H';
            peso = 0;
            altura = 0;
            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            generaDNI();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }
    
        public int calcularIMC()
        {
            double pesoIdeal = 0;
            pesoIdeal = peso / (Math.Pow(altura, 2));

            if(pesoIdeal < pesoMinimo)
            {
                return -1;
            }
            else if (pesoIdeal > pesoMaximo)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void mostrarIMC()
        {
            if(calcularIMC() == -1)
            {
                Console.WriteLine("Está por debajo de su peso ideal");
            }
            else if (calcularIMC() == 1) 
            {
                Console.WriteLine("Tiene sobrepeso");
            }
            else
            {
                Console.WriteLine("Está en su peso ideal");
            }
        }

        public bool esMayorDeEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comprobarSexo(char sexoUsuario)
        {
            if(sexoUsuario == 'H' || sexoUsuario == 'M')
            {
                sexo = sexoUsuario;
            }
            else
            {
                sexo = 'H';
            }
        }

        public override string ToString()
        {
            return base.ToString() + ": " + nombre + " " + edad + " " + DNI + " " + sexo + " " + peso + " " + altura;
        }

        private void generaDNI()
        {
            Random rnd = new Random();
            int numDNI = 0;
            int restoDNI = 0;
            char letraDNI = ' ';

            numDNI = rnd.Next(10000000, 100000000);
            restoDNI = numDNI % 23;

            switch (restoDNI)
            {
                case 0:
                    letraDNI = 'T';
                    break;
                case 1:
                    letraDNI = 'R';
                    break;
                case 2:
                    letraDNI = 'W';
                    break;
                case 3:
                    letraDNI = 'A';
                    break;
                case 4:
                    letraDNI = 'G';
                    break;
                case 5:
                    letraDNI = 'M';
                    break;
                case 6:
                    letraDNI = 'Y';
                    break;
                case 7:
                    letraDNI = 'F';
                    break;
                case 8:
                    letraDNI = 'P';
                    break;
                case 9:
                    letraDNI = 'D';
                    break;
                case 10:
                    letraDNI = 'X';
                    break;
                case 11:
                    letraDNI = 'B';
                    break;
                case 12:
                    letraDNI = 'N';
                    break;
                case 13:
                    letraDNI = 'J';
                    break;
                case 14:
                    letraDNI = 'Z';
                    break;
                case 15:
                    letraDNI = 'S';
                    break;
                case 16:
                    letraDNI = 'Q';
                    break;
                case 17:
                    letraDNI = 'V';
                    break;
                case 18:
                    letraDNI = 'H';
                    break;
                case 19:
                    letraDNI = 'L';
                    break;
                case 20:
                    letraDNI = 'C';
                    break;
                case 21:
                    letraDNI = 'K';
                    break;
                case 22:
                    letraDNI = 'E';
                    break;
                default:
                    break;
            }

            DNI = Convert.ToString(numDNI) + letraDNI;
        }
    }
}
