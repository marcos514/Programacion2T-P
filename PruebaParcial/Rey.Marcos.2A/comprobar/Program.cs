using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace comprobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavadero = new Lavadero("Filgo to d max");
            Auto auto = new Auto("aaa444", Vehiculo.EMarca.Fiat, 4);
            Moto moto = new Moto("jjj444", Vehiculo.EMarca.Ford, 100, 2);
            Vehiculo vehiculo = new Vehiculo("456", Vehiculo.EMarca.Zanella, 6);
            Camion camion = new Camion(vehiculo, 60);

            lavadero += auto;
            lavadero += moto;
            lavadero += camion;
            Console.WriteLine("Ingreso 3 vehiculos");
            Console.WriteLine(lavadero.VehiculosLista);
            Console.ReadLine();
            Console.WriteLine("Ingreso 1 vehiculos repetido");
            lavadero += camion;
            Console.WriteLine(lavadero.VehiculosLista);
            Console.ReadLine();

            Console.WriteLine("Borro 1 vehiculo");
            lavadero -= camion;
            Console.WriteLine(lavadero.VehiculosLista);
            Console.ReadLine();

            Console.WriteLine("Ordeno por marca");
            lavadero += camion;
            lavadero.Vehiculo.Sort(Lavadero.OrdenarVeiculosPorMarca);
            Console.WriteLine(lavadero.VehiculosLista);
            Console.ReadLine();

            Console.WriteLine("Ordeno por Patente");
            lavadero.Vehiculo.Sort(Lavadero.OrdenarVeiculosPorPatente);
            Console.WriteLine(lavadero.VehiculosLista);
            Console.ReadLine();

            Console.WriteLine("Muestro lavadero completo");
            Console.WriteLine(lavadero.Lavaderos);
            Console.ReadLine();

            Console.WriteLine("Muestro los precios");
            Console.WriteLine("Total Autos:" + lavadero.MostrarTotalFacturado(EVehiculo.Auto));
            Console.WriteLine("Total Camion:" + lavadero.MostrarTotalFacturado(EVehiculo.Camion));
            Console.WriteLine("Total Motos:" + lavadero.MostrarTotalFacturado(EVehiculo.Moto));
            Console.WriteLine("Total facturado:" + lavadero.MostrarTotalFacturado());
            Console.ReadLine();


            


            
            
            

            
        }
    }
}
