using EBid;

List<Subasta> subastas = new List<Subasta>
{
    new SubastaRelampago(1000m, 7),
    new SubastaPremium(5000m, 500m)
};

decimal[] rondasOfertas = { 1200m, 5300m, 6200m };

foreach (Subasta subasta in subastas)
{
    Console.WriteLine($"=== Evaluando subasta (precio inicial ${subasta.PrecioActual:F2}) ===");
    foreach (decimal oferta in rondasOfertas)
    {
        string respuesta = subasta.RegistrarOferta(oferta);
        Console.WriteLine(respuesta);
    }
}
