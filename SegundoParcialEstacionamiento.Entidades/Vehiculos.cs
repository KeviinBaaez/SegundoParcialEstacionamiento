using System.Text.RegularExpressions;

namespace SegundoParcialEstacionamiento.Entidades
{
    public abstract class Vehiculos
    {
        private string marca;
        private string modelo;
        private string patente;

        public string Marca 
        {
            get
            {
                return marca;
            }
            set
            {
                if (!string.IsNullOrEmpty(marca))
                {
                    marca = value;
                }
            }
        }
        public string Modelo 
        {
            get
            {
                return modelo;
            }
            set
            {
                if (!string.IsNullOrEmpty(modelo))
                {
                    marca = value;
                }
            }
        }
        public string Patente { get; set; }

        public Vehiculos()
        {
            
        }
        public Vehiculos(string marca, string modelo, string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
        }
        public bool ValidarPatente(string patente)
        {
            bool valido = true;
            if (string.IsNullOrEmpty(patente))
            {
                valido = false;
            }
            return valido;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} - Modelo: {Modelo} - Patente: {Patente}"
        }
    }
}
