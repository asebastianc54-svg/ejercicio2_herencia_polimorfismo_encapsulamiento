namespace SmartToll
{
    public class Vehiculo
    {
        private string patente = string.Empty;

        public string Patente
        {
            get => patente;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La patente no puede estar vacía.");
                }
                patente = value.Trim().ToUpper();
            }
        }

        public decimal Saldo { get; set; }

        public Vehiculo(string patente, decimal saldo)
        {
            Patente = patente;
            Saldo = saldo;
        }

        public virtual string PagarPeaje(decimal tarifa)
        {
            if (tarifa < 0)
            {
                return $"[{Patente}] Tarifa inválida.";
            }
            if (Saldo < tarifa)
            {
                return $"[{Patente}] Quedó varado: saldo insuficiente (${Saldo:F2}) para tarifa de ${tarifa:F2}.";
            }
            Saldo -= tarifa;
            return $"[{Patente}] Pasó el peaje. Saldo restante: ${Saldo:F2}.";
        }
    }
}
