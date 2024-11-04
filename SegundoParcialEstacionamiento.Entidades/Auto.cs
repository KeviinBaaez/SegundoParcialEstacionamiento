using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades
{
    public class Auto : Vehiculos, IVehiculos
    {
        private ConsoleColor color;
        public decimal valorHora;

        public ConsoleColor Color { get; set; }
        public Auto()
        {
            valorHora = 1800;
        }
        public Auto(string marca, string modelo, string patente) : base(marca, modelo, patente)
        {
        }

        public decimal ObtenerCostoPorHora()
        {
            return valorHora;
        }
    }
}
