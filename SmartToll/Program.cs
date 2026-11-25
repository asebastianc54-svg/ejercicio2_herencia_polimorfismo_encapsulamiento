using SmartToll;

decimal tarifaBase = 1500m;

List<Vehiculo> vehiculos = new List<Vehiculo>
{
    new Particular("AA123BB", 3000m),
    new Particular("AC456DD", 800m),
    new Camion("AE789FF", 10000m, 5),
    new Camion("AG111HH", 2000m, 3)
};

foreach (Vehiculo vehiculo in vehiculos)
{
    string resultado = vehiculo.PagarPeaje(tarifaBase);
    Console.WriteLine(resultado);
}
