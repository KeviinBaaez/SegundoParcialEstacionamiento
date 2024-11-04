namespace SegundoParcialEstacionamiento.Entidades
{
    public class Movimiento
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public decimal Costo { get; set; }
        public int Estadia { get; set; }
        public Vehiculos vehiculo { get; set; }
        public Movimiento()
        {
            
        }
        public Movimiento(Vehiculos vehiculo)
        {
            this.vehiculo = vehiculo;
        }
        public int CalcularEstadia()
        {
            if (!HoraSalida.HasValue)
            {
                throw new InvalidOperationException("No se ha registrado la hora de salida.");
            }

            TimeSpan estadia = HoraSalida.Value - HoraEntrada;
            return (int)estadia.TotalHours; // Convertimos a horas y retornamos
        }

    }

}
