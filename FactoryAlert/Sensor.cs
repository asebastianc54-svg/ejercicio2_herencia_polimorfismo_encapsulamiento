namespace FactoryAlert
{
    public class Sensor
    {
        private string id = string.Empty;
        private string estado = "Ok";

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El ID del sensor no puede estar vacío.");
                }
                id = value.Trim();
            }
        }

        public string Estado
        {
            get => estado;
            set
            {
                if (value != "Ok" && value != "Alerta" && value != "Peligro")
                {
                    throw new ArgumentException("Estado inválido. Debe ser Ok, Alerta o Peligro.");
                }
                estado = value;
            }
        }

        public Sensor(string id, string estado = "Ok")
        {
            Id = id;
            Estado = estado;
        }

        public virtual string EvaluarLectura(double valor)
        {
            return $"[{Id}] Lectura {valor:F1} registrada. Estado actual: {Estado}.";
        }
    }
}
