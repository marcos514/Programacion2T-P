using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Carrera
    {
        private List<Animal> _animales;
        private int _corredoresMax;

        private Carrera()
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredoresMax):this()
        {
            this._corredoresMax = corredoresMax;
        }

        public static bool operator ==(Carrera c1, Animal a1)
        {
            bool retorno = false;
            foreach(Animal animal in c1._animales)
            {
                if (a1 is Perro && animal is Perro)
                {
                    if(((Perro)a1) == ((Perro)animal))
                    {
                        retorno = true;
                    }
                }
                else if (a1 is Humano && animal is Humano)
                {
                    if (((Humano)a1) == ((Humano)animal))
                    {
                        retorno = true;
                    }
                }
                else if (a1 is Caballo && animal is Caballo)
                {
                    if (((Caballo)a1) == ((Caballo)animal))
                    {
                        retorno = true;
                    }
                }

            }
            return retorno;
        }

        public static bool operator != (Carrera c1, Animal a1)
        {
            return !(c1 == a1);
        }

        public static Carrera operator +(Carrera c1,Animal a1)
        {
            Carrera carrera=new Carrera(c1._corredoresMax);
            carrera._animales = c1._animales;
            if(carrera._animales.Count<carrera._corredoresMax)
            {
                if(carrera!=a1)
                {
                    carrera._animales.Add(a1);
                }
            }
            
            return carrera;
        }

        public string MostrarCarrera()
        {
            StringBuilder retorno = new StringBuilder();
            Animal auxiliar;
            for (int i=0;i<this._animales.Count;i++)
            {
                auxiliar = this._animales[i];
                if(auxiliar is Perro)
                {
                    retorno.AppendLine(((Perro)auxiliar).MostrarPerro());
                }
                else if (auxiliar is Humano)
                {
                    retorno.AppendLine(((Humano)auxiliar).MostrarHumano());
                }
                else if (auxiliar is Caballo)
                {
                    retorno.AppendLine(((Caballo)auxiliar).MostrarCaballo());
                }
            }
            return retorno.ToString();
        }
    }
}
