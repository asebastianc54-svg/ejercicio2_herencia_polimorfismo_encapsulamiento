namespace SmartToll
{
    public class Camion : Vehiculo
    {
        public int Ejes { get; set; }

        public Camion(string patente, decimal saldo, int ejes) : base(patente, saldo)
        {
            Ejes = ejes > 0 ? ejes : 2;
        }

        public override string PagarPeaje(decimal tarifa)
        {
            if (tarifa < 0)
            {
                return $"[{Patente}] Tarifa inválida.";
            }
            decimal total = tarifa * Ejes;
            bool tieneDescuento = Ejes > 4;
            if (tieneDescuento)
            {
                total *= 0.90m;
            }
            if (Saldo < total)
            {
                return $"[{Patente}] Camión de {Ejes} ejes quedó varado: necesita ${total:F2}, tiene ${Saldo:F2}.";
            }
            Saldo -= total;
            if (tieneDescuento)
            {
                return $"[{Patente}] Camión de {Ejes} ejes pasó con 10% de descuento aplicado (${total:F2}). Saldo restante: ${Saldo:F2}.";
            }
            return $"[{Patente}] Camión de {Ejes} ejes pasó (${total:F2}). Saldo restante: ${Saldo:F2}.";
        }
    }
}
