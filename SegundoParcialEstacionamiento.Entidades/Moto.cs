namespace SegundoParcialEstacionamiento.Entidades
{
    public class Moto : Vehiculos, IVehiculos
    {
        private int cilindrada;
        public decimal valorHora;

        public int Cilindrada { get; set; }
        public Moto()
        {
            valorHora = 1000;
        }
        public Moto(string marca, string modelo, string patente, int cilindrada):base(marca, modelo, patente)
        {
            this.cilindrada = cilindrada;
        }

        public decimal ObtenerCostoPorHora()
        {
            return valorHora;
        }
    }
}
