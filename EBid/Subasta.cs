namespace EBid
{
    public class Subasta
    {
        private decimal precioActual;

        public decimal PrecioActual
        {
            get => precioActual;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio actual no puede ser negativo.");
                }
                precioActual = value;
            }
        }

        public Subasta(decimal precioActual)
        {
            PrecioActual = precioActual;
        }

        public virtual string RegistrarOferta(decimal oferta)
        {
            if (oferta > PrecioActual)
            {
                PrecioActual = oferta;
                return $"Oferta de ${oferta:F2} aceptada. Nuevo precio actual: ${PrecioActual:F2}.";
            }
            return $"Oferta de ${oferta:F2} rechazada por no superar el precio actual (${PrecioActual:F2}).";
        }
    }
}
