using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(Vehiculo vehiculo, float tara): base(vehiculo.Patente, vehiculo.Marca, vehiculo.Ruedas)
        {
            this._tara = tara;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append(" Tara: ");
            retorno.AppendLine(this._tara.ToString());
            return retorno.ToString() ;
        }
    }
}
