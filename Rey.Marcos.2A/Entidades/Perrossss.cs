using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Perro : Animal
    {
        static private int _patas;
        private Raza _raza;
        enum Raza { Galgo, ObejeroAleman };

        static Perro()
        {
            Perrossss._patas = 4;
        }

        public Perro(int velocidadMaxima) : this(Raza.Galgo, velocidadMaxima)
        {

        }

        public Perro(Raza raza, int velocidadMaxima) : base(4, velocidadMaxima)
        {
            this._raza = raza;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (p1._raza == p2._raza) && (p1._velocidadMaxima == p2._velocidadMaxima);
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public string MostrarPerro()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarDatos());
            retorno.Append("Raza: ");
            retorno.Append(this._raza.ToString());
            return retorno.ToString();
        }


    }
}
