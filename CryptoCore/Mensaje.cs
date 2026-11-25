namespace CryptoCore
{
    public class Mensaje
    {
        private string textoOriginal = string.Empty;

        public string TextoOriginal
        {
            get => textoOriginal;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El texto original no puede estar vacío.");
                }
                foreach (char c in value)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        throw new ArgumentException("El texto original no admite caracteres especiales.");
                    }
                }
                textoOriginal = value;
            }
        }

        public Mensaje(string textoOriginal)
        {
            TextoOriginal = textoOriginal;
        }

        public virtual string Cifrar()
        {
            return TextoOriginal;
        }
    }
}
