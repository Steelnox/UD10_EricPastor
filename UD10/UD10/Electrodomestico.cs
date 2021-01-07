using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Electrodomestico
    {
        protected double precio_base;
        protected string color;
        protected char consumo_ener;
        protected float peso;

        public Electrodomestico()
        {
            precio_base = 100;
            color = "blanco";
            consumo_ener = 'F';
            peso = 5;
        }

        public Electrodomestico(double precio_base, float peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
            color = "blanco";
            consumo_ener = 'F';
        }

        public Electrodomestico(double precio_base, string color, char consumo_ener, float peso)
        {
            this.precio_base = precio_base;
            this.consumo_ener = consumo_ener;
            if (comprobarConsumoEnergetico(consumo_ener))
            {
                this.consumo_ener = consumo_ener;
            }
            else
            {
                this.consumo_ener = 'F';
            }
            this.peso = peso;
            if(ValidarColor(color))
            {
                color = color.ToLower();
                this.color = color;
            }
            else
            {
                this.color = "blanco";
            }
        }

        public double Precio_base { get => precio_base; set => precio_base = value; }
        public string Color { get => color; set => color = value; }
        public char Consumo_ener { get => consumo_ener; set => consumo_ener = value; }
        public float Peso { get => peso; set => peso = value; }

        private bool ValidarColor(string valid_color)
        {
            string[] tipo_color = {"blanco", "negro", "rojo", "azul", "gris"};
            valid_color = valid_color.ToLower();

            for (int i = 0; i < tipo_color.Length; i++)
            {
                if (valid_color == tipo_color[i]) return true;
            }

            return false;
        }

        private bool comprobarConsumoEnergetico(char letra)
        {
            char[] tipo_letra = { 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < tipo_letra.Length; i++)
            {
                if (letra == tipo_letra[i]) return true;
            }

            return false;
        }

        public void Mostrar()
        {
            Console.WriteLine("El precio base es {0}, es de color {1}, tiene un consumo energetico de {2} y su peso es de {3} kg", precio_base, color, consumo_ener, peso);
        }

        public virtual void precioFinal()
        {
            switch(consumo_ener)
            {
                case 'A':
                    precio_base += 100;
                    break;
                case 'B':
                    precio_base += 80;
                    break;
                case 'C':
                    precio_base += 60;
                    break;
                case 'D':
                    precio_base += 50;
                    break;
                case 'E':
                    precio_base += 30;
                    break;
                case 'F':
                    precio_base += 10;
                    break;
                default:
                    break;
            }

            if (peso >= 0 && peso <= 19) precio_base += 10;
            else if (peso >= 20 && peso <= 49) precio_base += 50;
            else if (peso >= 50 && peso <= 79) precio_base += 80;
            else precio_base += 100;

        }
    }
}
