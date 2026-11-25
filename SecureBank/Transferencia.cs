namespace SecureBank
{
    public class Transferencia : Transaccion
    {
        public decimal Monto { get; set; }
        public string CuentaDestino { get; set; } = string.Empty;

        public Transferencia(string tokenSeguridad, decimal monto, string cuentaDestino) : base(tokenSeguridad)
        {
            Monto = monto;
            CuentaDestino = cuentaDestino;
        }

        public override string Procesar()
        {
            if (Monto > 500000m)
            {
                return "Requiere autorización presencial";
            }
            return $"[Token {TokenSeguridad}] Transferencia de ${Monto:F2} hacia {CuentaDestino} autorizada.";
        }
    }
}
