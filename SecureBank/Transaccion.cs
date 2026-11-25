namespace SecureBank
{
    public class Transaccion
    {
        private string tokenSeguridad = string.Empty;

        public string TokenSeguridad
        {
            get => tokenSeguridad;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 8)
                {
                    throw new ArgumentException("El token de seguridad debe tener exactamente 8 caracteres.");
                }
                tokenSeguridad = value;
            }
        }

        public Transaccion(string tokenSeguridad)
        {
            TokenSeguridad = tokenSeguridad;
        }

        public virtual string Procesar()
        {
            return $"[Token {TokenSeguridad}] Transacción base autorizada y procesada.";
        }
    }
}
