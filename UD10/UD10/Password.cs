using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    public class Password
    {
        private int longitud;
        private char[] contraseña;

        public Password()
        {
            longitud = 8;
            contraseña = new char[longitud];
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = new char[longitud];
            GenerarContraseña();
        }

        public int Longitud { get => longitud; set => longitud = value; }
        public char[] Contraseña { get => contraseña;}

        private void GenerarContraseña()
        {
            Random rand = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            for (int i = 0; i < contraseña.Length; i++)
            {
                contraseña[i] = (char)caracteres[rand.Next(caracteres.Length)];
            }
        }

        public void MostrarContraseña()
        {
            for (int i = 0; i < contraseña.Length; i++)
            {
                if(i == contraseña.Length - 1)
                {
                    Console.Write(contraseña[i] + " ");
                }
                else
                {
                    Console.Write(contraseña[i]);
                }
            }
        }

        public bool esFuerte()
        {
            int mayus = 0;
            int minus = 0;
            int num = 0;

            for (int i = 0; i < contraseña.Length; i++)
            {
               if(Char.IsUpper(contraseña[i]))
                {
                    mayus++;
                }
               else if (Char.IsLower(contraseña[i]))
                {
                    minus++;
                }
               else
                {
                    num++;
                }
            }

            if(mayus > 2 && minus > 1 && num > 5)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
