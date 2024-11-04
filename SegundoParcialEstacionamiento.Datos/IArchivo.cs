namespace SegundoParcialEstacionamiento.Datos
{
    public interface IArchivo<T> where T : class
    {
        public void GuardarDatos(List<T> entidades);
        public List<T> LeerDatos();
    }
}
