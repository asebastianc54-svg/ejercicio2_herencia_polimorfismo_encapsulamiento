using AeroCheck;

List<Aeronave> aeronaves = new List<Aeronave>
{
    new AvionComercial(12450, 180),
    new AvionComercial(4200, 150),
    new Helicoptero(320, 600),
    new Helicoptero(150, 400)
};

foreach (Aeronave aeronave in aeronaves)
{
    string reporte = aeronave.GenerarReporteMantenimiento();
    Console.WriteLine(reporte);
}
