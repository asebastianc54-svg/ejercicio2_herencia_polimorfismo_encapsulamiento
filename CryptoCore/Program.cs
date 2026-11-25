using CryptoCore;

string textoComun = "Mensaje secreto 2026";

List<Mensaje> mensajes = new List<Mensaje>
{
    new CifradoInvertido(textoComun),
    new CifradoDesplazamiento(textoComun, 3),
    new Mensaje(textoComun)
};

foreach (Mensaje mensaje in mensajes)
{
    string cifrado = mensaje.Cifrar();
    Console.WriteLine($"{mensaje.GetType().Name}: {cifrado}");
}
