using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(string patente, EMarca marca, float cilindrada,byte cantidadRuedas)
            : base(patente, marca, cantidadRuedas)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append(" Cilindrada: ");
            retorno.AppendLine(this._cilindrada.ToString());
            return retorno.ToString() ;
        }

    }
}
