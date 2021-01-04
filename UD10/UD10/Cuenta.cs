using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
            cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return titular.ToString() + ": " + cantidad.ToString();
        }
        public void Ingresar(double dinero)
        {
            if(dinero >= 0)
            {
                cantidad += dinero;
            }
        }

        public void Retirar(double dinero)
        {
            cantidad -= dinero;

            if(cantidad < 0)
            {
                cantidad = 0;
            }
        }
    }
}
