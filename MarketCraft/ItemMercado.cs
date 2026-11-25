namespace MarketCraft
{
    public class ItemMercado
    {
        private string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del ítem no puede estar vacío.");
                }
                nombre = value.Trim();
            }
        }

        public decimal PrecioBase { get; set; }
        public int Stock { get; set; }

        public ItemMercado(string nombre, decimal precioBase, int stock)
        {
            Nombre = nombre;
            PrecioBase = precioBase;
            Stock = stock;
        }

        public virtual string CotizarVenta(int cantidad)
        {
            if (cantidad <= 0)
            {
                return $"[{Nombre}] Cantidad inválida.";
            }
            if (Stock <= 0)
            {
                return $"[{Nombre}] Sin stock disponible.";
            }
            int entregados = Math.Min(cantidad, Stock);
            Stock -= entregados;
            decimal total = PrecioBase * entregados;
            return $"[{Nombre}] Venta de {entregados} unidad(es) por ${total:F2}. Stock restante: {Stock}.";
        }
    }
}
