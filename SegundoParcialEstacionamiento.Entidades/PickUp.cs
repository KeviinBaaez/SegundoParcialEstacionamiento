using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades
{
    public class PickUp : Vehiculos, IVehiculos
    {
        private int carga;
        public decimal valorHora;

        public int Cilindrada { get; set; }
        public PickUp()
        {
            valorHora = 2000;
        }
        public PickUp(string marca, string modelo, string patente, int carga) : base(marca, modelo, patente)
        {
            this.carga = carga;
        }

        public decimal ObtenerCostoPorHora()
        {
            return valorHora;
        }
    }
}
