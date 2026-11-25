namespace SecureBank
{
    public class PagoServicio : Transaccion
    {
        public decimal Importe { get; set; }
        public int DiasVencido { get; set; }

        public PagoServicio(string tokenSeguridad, decimal importe, int diasVencido) : base(tokenSeguridad)
        {
            Importe = importe;
            DiasVencido = diasVencido;
        }

        public override string Procesar()
        {
            if (DiasVencido > 0)
            {
                double tasaDiaria = 0.015;
                double montoCompuesto = (double)Importe * Math.Pow(1.0 + tasaDiaria, DiasVencido);
                return $"[Token {TokenSeguridad}] Servicio vencido hace {DiasVencido} día(s). Total con interés compuesto: ${montoCompuesto:F2}.";
            }
            return $"[Token {TokenSeguridad}] Servicio pagado en término por ${Importe:F2}.";
        }
    }
}
