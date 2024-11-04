using SegundoParcialEstacionamiento.Entidades;

namespace SegundoParcialEstacionamiento.Datos
{
    public class Estacionamiento
    {
        private int capacidad;
        private ManejadorDeArchivoSecuencial manejadorDeArchivoSecuencial;
        private List<Movimiento> movimientos;
        private string nombre;
        private Serializador serializador;
        private Dictionary<string, Vehiculos> vehiculos;

        public string Nombre 
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    nombre = value;
                }
            }
        }
        public List<Movimiento> Movimientos { get; set; }

        public int Capacidad
        {
            get { return capacidad; }
            set
            {
                if (capacidad > 0)
                {
                    capacidad = value;
                }
            }
        }
        private Estacionamiento()
        {
            movimientos = new List<Movimiento>();
            serializador = new Serializador();
            manejadorDeArchivoSecuencial = new ManejadorDeArchivoSecuencial();
        }
        public Estacionamiento(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Estacionamiento(string nombre, int capacidad):this(nombre)
        {
            this.capacidad = capacidad;
        }
        public (bool, string) IngresarVehiculo(Vehiculos vehiculo)
        {
            if (HayLugarDisponible())
            {
                vehiculos.Add("1", vehiculo);
                return (true, "Vehiculo Agregado");
            }
            return (false, "No se pudo agregar el vehiculo");
        }

        private bool HayLugarDisponible()
        {
            int lugares = 0;
            if(lugares < capacidad )
            {
                return true;
                lugares++;
            }
            return false;
        }
        public void GuardarDatos()
        {
            serializador.GuardarDatos(movimientos);
        }
        public Dictionary<string, Vehiculos> LeerDatos()
        {
            serializador.LeerDatos();
            manejadorDeArchivoSecuencial.LeerDatos();
            
        }
    }
}
