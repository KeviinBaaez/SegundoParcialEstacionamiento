using SegundoParcialEstacionamiento.Entidades;
using System.Xml.Serialization;

namespace SegundoParcialEstacionamiento.Datos
{
    public class ManejadorDeArchivoSecuencial : IArchivo<Vehiculos>
    {
        private readonly string path = Environment.CurrentDirectory;
        private readonly string archivo = "Vehiculos.txt";

        private string nombreArchivo;
        public ManejadorDeArchivoSecuencial()
        {
            nombreArchivo = Path.Combine(path, archivo);
        }
        public string ConstruirLinea(Vehiculos vehiculo)
        {
            string lineaLeida = $"{vehiculo.Marca}|{vehiculo.Modelo}|{vehiculo.Patente}";
            return lineaLeida;
        }
        public Vehiculos ConstruirVehiculo(string linea)
        {
            var campos = linea.Split('|');
            var marca = campos[0];
            var modelo = campos[1];
            var patente = campos[2];
            if(campos.Length > 3)
            {
                var cilindrada = int.Parse(campos[3]);
                return new Moto(marca, modelo, patente, cilindrada);
            }
            if (campos.Length > 3)
            {
                var carga = int.Parse(campos[3]);
                return new PickUp(marca, modelo, patente, carga);
            }
            return new Auto(marca, modelo, patente);


        }

        public void GuardarDatos(List<Vehiculos> entidades)
        {
            using(var escritor = new StreamWriter(nombreArchivo))
            {
                List<Vehiculos> lista = new List<Vehiculos>();
                foreach (var item in entidades)
                {
                    lista.Add(item);
                    escritor.WriteLine(entidades);
                }
            }
        }

        public List<Vehiculos> LeerDatos()
        {
            if (File.Exists(nombreArchivo))
            {
                using(var lector = new StreamReader(nombreArchivo))
                {
                    while()
                }
            }
        }
    }
}
