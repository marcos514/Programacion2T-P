using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Humano : Animal
    {
        private string _apellido;
        private string _nombre;
        static private int _piernas;

        static Humano()
        {
            Humano._piernas = 2;
        }

        public Humano(int velocidadMaxima):this("","",velocidadMaxima)
        {

        }

        public Humano(string nombre, string apellido, int velocidadMaxima) : base(2,velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string MostrarHumano()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarDatos());
            retorno.Append(" Nombre Apellido: ");
            retorno.AppendLine(this._nombre + this._apellido);
            return retorno.ToString();
        }

        public static  bool operator ==(Humano h1,Humano h2)
        {
            return (h1._apellido == h2._apellido) && (h1._nombre == h2._nombre);
        }

        public static bool operator !=(Humano h1,Humano h2)
        {
            return !(h1 == h2);
        }

    }
}
