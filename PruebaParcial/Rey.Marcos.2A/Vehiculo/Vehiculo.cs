using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        public enum EMarca { Honda, Ford, Zanella, Scania, Iveco, Fiat };
        protected EMarca _marca;

        public Vehiculo(string patente, EMarca marca, Byte cantRuerdas)
        {
            this._cantRuedas=cantRuerdas;
            this._patente=patente;
            this._marca = marca;
        }

        public string Patente 
        {
            get
            {
                return this._patente;
            }
        
        }
        public Byte Ruedas
        {
            get
            {
                return this._cantRuedas;
            }

        }
        public EMarca Marca
        {
            get
            {
                return this._marca;
            }

        }

        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("Patente: ");
            retorno.AppendLine(this.Patente);
            retorno.Append(" Marca: ");
            retorno.AppendLine(this.Marca.ToString());
            retorno.Append(" Cantidad de ruedas: ");
            retorno.AppendLine(this._cantRuedas.ToString());
            
            
            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Marca == v2.Marca) && (v1.Patente == v2.Patente);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
