namespace MarketCraft
{
    public class Pocion : ItemMercado
    {
        public Pocion(string nombre, decimal precioBase, int stock) : base(nombre, precioBase, stock)
        {
        }

        public override string CotizarVenta(int cantidad)
        {
            if (cantidad <= 0)
            {
                return $"[{Nombre}] Cantidad inválida.";
            }
            if (Stock <= 0)
            {
                return $"[{Nombre}] Sin pociones disponibles en stock.";
            }
            if (cantidad > Stock)
            {
                int remanente = Stock;
                decimal totalRemanente = PrecioBase * remanente;
                Stock = 0;
                return $"[{Nombre}] Solo quedan {remanente} unidad(es) disponibles; se ofrece el remanente por un total de ${totalRemanente:F2}.";
            }
            Stock -= cantidad;
            decimal total = PrecioBase * cantidad;
            return $"[{Nombre}] Cotización confirmada: {cantidad} poción(es) por ${total:F2}. Stock restante: {Stock}.";
        }
    }
}
