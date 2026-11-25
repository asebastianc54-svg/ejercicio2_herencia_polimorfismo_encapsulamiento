using NetFetch;

List<Descarga> descargas = new List<Descarga>
{
    new StreamingVideo(100, 50),
    new ArchivoComprimido(100, false)
};

for (int paso = 1; paso <= 4; paso++)
{
    Console.WriteLine($"--- Paso de tiempo {paso} (+35 MB) ---");
    foreach (Descarga descarga in descargas)
    {
        string estado = descarga.ActualizarProgreso(35);
        Console.WriteLine(estado);
    }
}
