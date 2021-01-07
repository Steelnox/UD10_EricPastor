using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Lavadora : Electrodomestico
    {
        const int carga_def = 5;
        protected int carga;

        public Lavadora()
        {
            carga = carga_def;
            precio_base = 100;
            color = "blanco";
            consumo_ener = 'F';
            peso = 5;
        }

        public Lavadora(double precio_base, float peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
            color = "blanco";
            consumo_ener = 'F';
            carga = carga_def;
        }

        public Lavadora(int carga, Electrodomestico electro)
        {
            this.carga = carga;
            this.precio_base = electro.Precio_base;
            this.peso = electro.Peso;
            this.color = electro.Color;
            this.consumo_ener = electro.Consumo_ener;
        }
        public int Carga { get => carga; set => carga = value; }

        public override void precioFinal()
        {
            base.precioFinal();

            if(carga > 30)
            {
                precio_base += 50;
            }
        }
    }
}
