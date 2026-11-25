using BioTech;

List<Planta> plantas = new List<Planta>
{
    new Cactus(30, 80),
    new Helecho(15, 70, 75)
};

string[] secuenciaClimas = { "Seco", "Lluvioso" };

foreach (string clima in secuenciaClimas)
{
    Console.WriteLine($"=== Clima: {clima} ===");
    foreach (Planta planta in plantas)
    {
        string reporte = planta.AplicarClima(clima);
        Console.WriteLine(reporte);
    }
}
