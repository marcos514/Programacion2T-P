using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Caballo : Animal
    {
        private static int _patas;
        private string _nombre;

        static Caballo()
        {
            Caballo._patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) : base(4,velocidadMaxima)
        {
            this._nombre = nombre;
        }

        public string MostrarCaballo()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarDatos());
            retorno.Append(" Nombre: ");
            retorno.AppendLine(this._nombre);
            return retorno.ToString();
        }

        public static bool operator ==(Caballo c1,Caballo c2)
        {
            return (c1._nombre == c2._nombre);
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }
    }
}
