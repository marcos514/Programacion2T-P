using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculo;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        static Lavadero()
        {
            Random precio=new Random();

            Lavadero._precioAuto = precio.Next(150, 560);

            Lavadero._precioCamion = precio.Next(150, 560);
            while (Lavadero._precioCamion == Lavadero._precioAuto)
            {
                Lavadero._precioCamion = precio.Next(150, 560);
            }

            Lavadero._precioMoto = precio.Next(150, 560);
            while (Lavadero._precioMoto == Lavadero._precioAuto && Lavadero._precioMoto != Lavadero._precioAuto)
            {
                Lavadero._precioMoto = precio.Next(150, 560);
            }
        }

        private Lavadero()
        {
            this._vehiculo = new List<Vehiculo>();
        }


        public Lavadero(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }

        public string Lavaderos
        {
            get
            {
                StringBuilder retorno = new StringBuilder();
                retorno.AppendLine(this._razonSocial);
                retorno.Append(" Precio auto: ");
                retorno.AppendLine(Lavadero._precioAuto.ToString());
                retorno.Append(" Precio camion: ");
                retorno.AppendLine(Lavadero._precioCamion.ToString());
                retorno.Append(" Precio moto: ");
                retorno.AppendLine(Lavadero._precioMoto.ToString());


                foreach (Vehiculo vehiclo in this._vehiculo)
                {
                    retorno.AppendLine(vehiclo.ToString());
                }
                //retorno.AppendLine(this.VehiculosLista);
                
                return retorno.ToString();
            }
        }

        public string VehiculosLista
        {
            get
            { 
                StringBuilder retorno = new StringBuilder();

                foreach (Vehiculo vehiclo in this._vehiculo)
                {
                    if (vehiclo is Auto)
                    {
                        retorno.AppendLine(((Auto)vehiclo).ToString());
                    }
                    else if (vehiclo is Camion)
                    {
                        retorno.AppendLine(((Camion)vehiclo).ToString());
                    }
                    else if (vehiclo is Moto)
                    {
                        retorno.AppendLine(((Moto)vehiclo).ToString());
                    }
                }
                return retorno.ToString();
            }
        }


        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculo.Auto) + this.MostrarTotalFacturado(EVehiculo.Camion) + this.MostrarTotalFacturado(EVehiculo.Moto);
        }


        public double MostrarTotalFacturado(EVehiculo vehiculo)
        {
            double retorno=0;
            double retornoAuto=0;
            double retornoCamion=0;
            double retornoMoto=0;
            foreach(Vehiculo aux in this._vehiculo)
             {
               if(aux is Auto)
               {
                 retornoAuto+=Lavadero._precioAuto;
               }
               else if(aux is Camion)
               {
                    retornoCamion+=Lavadero._precioCamion;
               }
                else if(aux is Moto)
                {
                     retornoMoto+=Lavadero._precioMoto;
                }
            }

            switch (vehiculo)
	        {
		        case EVehiculo.Auto:
                    retorno+=retornoAuto;
                 break;
                case EVehiculo.Camion:
                    retorno+=retornoCamion;
                break;
                case EVehiculo.Moto:
                    retorno+=retornoMoto;
                break;
	        }
                    
       
            return retorno;
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach (Vehiculo aux in lavadero._vehiculo)
            {
                if (vehiculo==aux)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            Lavadero aux = new Lavadero(lavadero._razonSocial);
            aux._vehiculo = lavadero._vehiculo;
            if (aux != vehiculo)
            {
                aux._vehiculo.Add(vehiculo);
            }
            
            return aux;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            Lavadero aux = new Lavadero(lavadero._razonSocial);
            aux._vehiculo = lavadero._vehiculo;
            int indice = (vehiculo == lavadero);

            if (indice != -1)
            {
                lavadero._vehiculo.RemoveAt(indice);
            }

            return aux;
        }

        public static int operator ==(Vehiculo vehiculo, Lavadero lavadero)
        {
            int retorno = 0;
            if (lavadero == vehiculo)
            {
                for (int i = 0; i < lavadero._vehiculo.Count; i++)
                {
                    if (lavadero._vehiculo[i] == vehiculo)
                    {
                        retorno = i;
                        break;
                    }
                }
            }
            else
            {
                retorno = -1;
            }

            return retorno;
            
        }

        public static int operator !=(Vehiculo vehiculo, Lavadero lavadero)
        {
            return 0;
        }
        public static int OrdenarVeiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente.CompareTo(v2.Patente);
        }

        public static int OrdenarVeiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.Marca.ToString().CompareTo(v2.Marca.ToString());
        }

        public List<Vehiculo> Vehiculo
        {
            get
            {
                return this._vehiculo;
            }
        
        }




    }
}
