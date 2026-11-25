using MarketCraft;

List<ItemMercado> items = new List<ItemMercado>
{
    new Pocion("Poción de Vida Mayor", 50m, 6),
    new MineralRaro("Mitril Estelar", 200m, 4, 1.5m),
    new ItemMercado("Lingote de Hierro", 30m, 15)
};

foreach (ItemMercado item in items)
{
    string cotizacion = item.CotizarVenta(10);
    Console.WriteLine(cotizacion);
}
