namespace SmartToll
{
    public class Particular : Vehiculo
    {
        public Particular(string patente, decimal saldo) : base(patente, saldo)
        {
        }

        public override string PagarPeaje(decimal tarifa)
        {
            if (tarifa < 0)
            {
                return $"[{Patente}] Tarifa inválida.";
            }
            if (Saldo < tarifa)
            {
                return $"Paso denegado";
            }
            Saldo -= tarifa;
            return $"[{Patente}] Vehículo particular pasó. Saldo restante: ${Saldo:F2}.";
        }
    }
}
