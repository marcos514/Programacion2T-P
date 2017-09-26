using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto :Vehiculo
    {
        protected int _cantAsientos;

        public Auto(string patente, EMarca marca, int cantAsientos):base(patente,marca,4)
        {
            this._cantAsientos = cantAsientos;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append(" Cantidad asientos");
            retorno.AppendLine(this._cantAsientos.ToString());
            return retorno.ToString() ;
        }
    }
}
