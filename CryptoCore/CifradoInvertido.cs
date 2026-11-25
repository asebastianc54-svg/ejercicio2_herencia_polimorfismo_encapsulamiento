namespace CryptoCore
{
    public class CifradoInvertido : Mensaje
    {
        public CifradoInvertido(string textoOriginal) : base(textoOriginal)
        {
        }

        public override string Cifrar()
        {
            char[] caracteres = TextoOriginal.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
