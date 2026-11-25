namespace MarketCraft
{
    public class MineralRaro : ItemMercado
    {
        public decimal FactorEscasez { get; set; }

        public MineralRaro(string nombre, decimal precioBase, int stock, decimal factorEscasez) : base(nombre, precioBase, stock)
        {
            FactorEscasez = factorEscasez;
        }

        public override string CotizarVenta(int cantidad)
        {
            if (cantidad <= 0)
            {
                return $"[{Nombre}] Cantidad inválida.";
            }
            if (Stock <= 0)
            {
                return $"[{Nombre}] No hay unidades disponibles de {Nombre}.";
            }
            int entregados = Math.Min(cantidad, Stock);
            bool escasezActiva = Stock < 5;
            decimal precioUnitario = escasezActiva ? PrecioBase * FactorEscasez : PrecioBase;
            decimal totalFinal = precioUnitario * entregados;
            Stock -= entregados;

            if (escasezActiva)
            {
                return $"[{Nombre}] ¡Precio inflado por alta demanda! {entregados} unidad(es) a ${totalFinal:F2}. Stock restante: {Stock}.";
            }
            return $"[{Nombre}] {entregados} unidad(es) vendidas por ${totalFinal:F2}. Stock restante: {Stock}.";
        }
    }
}
