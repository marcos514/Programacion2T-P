using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Animal
    {
        protected int _cantidadPatas;
        static protected Random _distaciaRecorrida;
        protected int _velocidadMaxima;

        #region GetSet
        public int CantidadPatas
        {
            get
            {
                return this._cantidadPatas;
            }
                
            set
            {
                if(value > 4)
                {
                    value = 4;
                }
                this._cantidadPatas = value;
               
            }
        }

        private int DistanciaRecorrida 
        {
            get
            {
                return Animal._distaciaRecorrida.Next(10, this._velocidadMaxima);
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                if(value>60)
                {
                    value = 60;
                }
                this._velocidadMaxima = value;
            }
        }
        #endregion GetSet

        public Animal(int cantidadPatas,int velocidadMaxima)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima; 
        }

        static Animal()
        {
            Animal._distaciaRecorrida = new Random();
        }


        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Cantidad de patas: ");
            retorno.Append(this._cantidadPatas);
            retorno.Append(" Velocidad maxima: ");
            retorno.Append(this.VelocidadMaxima.ToString());
            retorno.Append(" Distancia recorrida: ");
            retorno.Append(this.DistanciaRecorrida.ToString());

            return retorno.ToString();
        }

    }
}
