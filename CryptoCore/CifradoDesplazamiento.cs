namespace CryptoCore
{
    public class CifradoDesplazamiento : Mensaje
    {
        public int ClaveNumerica { get; set; }

        public CifradoDesplazamiento(string textoOriginal, int claveNumerica) : base(textoOriginal)
        {
            ClaveNumerica = claveNumerica;
        }

        public override string Cifrar()
        {
            int desplazamiento = ((ClaveNumerica % 26) + 26) % 26;
            char[] resultado = new char[TextoOriginal.Length];

            for (int i = 0; i < TextoOriginal.Length; i++)
            {
                char c = TextoOriginal[i];
                if (c >= 'a' && c <= 'z')
                {
                    resultado[i] = (char)('a' + ((c - 'a' + desplazamiento) % 26));
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    resultado[i] = (char)('A' + ((c - 'A' + desplazamiento) % 26));
                }
                else
                {
                    resultado[i] = c;
                }
            }

            return new string(resultado);
        }
    }
}
