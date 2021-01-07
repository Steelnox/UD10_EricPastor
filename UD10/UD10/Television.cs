using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Television : Electrodomestico
    {
        float resolucion;
        bool sintonizador;

        public Television()
        {
            resolucion = 20;
            sintonizador = false;
            precio_base = 100;
            color = "blanco";
            consumo_ener = 'F';
            peso = 5;
        }

        public Television(double precio_base, float peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
            color = "blanco";
            consumo_ener = 'F';
            resolucion = 20;
            sintonizador = false;
        }

        public Television(float resolucion, bool sintonizador, Electrodomestico electro)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
            this.precio_base = electro.Precio_base;
            this.peso = electro.Peso;
            this.color = electro.Color;
            this.consumo_ener = electro.Consumo_ener;
        }

        public float Resolucion { get => resolucion; set => resolucion = value; }

        public override void precioFinal()
        {
            double incremento = 0;
            base.precioFinal();
            if(resolucion > 40)
            {
                incremento = precio_base * 0.3f;
                precio_base += incremento;
            }

            if (sintonizador) precio_base += 50;
        }


    }
}
