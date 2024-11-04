using SegundoParcialEstacionamiento.Entidades;
using System.Xml.Serialization;

namespace SegundoParcialEstacionamiento.Datos
{
    public class Serializador : IArchivo<Movimiento>
    {
        private readonly string path = Environment.CurrentDirectory;
        private readonly string archivo = "Movimientos.Xml";
        private string nombreArchivo;

        public Serializador()
        {
            nombreArchivo = Path.Combine(path, archivo);
        }
        public void GuardarDatos(List<Movimiento> entidades)
        {
            using(var escritor = new StreamWriter(nombreArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Movimiento>));
                serializer.Serialize(escritor, entidades);
            }
        }

        public List<Movimiento> LeerDatos()
        {
            List<Movimiento> lista = new List<Movimiento>();
            if (File.Exists(nombreArchivo))
            {
                using(var lector = new StreamReader(nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Movimiento>));
                    return serializer.Deserialize(lector) as List<Movimiento>;
                }
            }
            return lista;
        }
    }
}
