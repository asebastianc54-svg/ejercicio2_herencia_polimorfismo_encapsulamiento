namespace EBid
{
    public class SubastaPremium : Subasta
    {
        public decimal MontoMinimoIncremento { get; set; }

        public SubastaPremium(decimal precioActual, decimal montoMinimoIncremento) : base(precioActual)
        {
            MontoMinimoIncremento = montoMinimoIncremento;
        }

        public override string RegistrarOferta(decimal oferta)
        {
            decimal minimoRequerido = PrecioActual + MontoMinimoIncremento;
            if (oferta > minimoRequerido)
            {
                PrecioActual = oferta;
                return $"[Premium] Oferta de ${oferta:F2} aceptada (superó ${minimoRequerido:F2}). Nuevo precio: ${PrecioActual:F2}.";
            }
            return $"[Premium] Oferta de ${oferta:F2} rechazada: debe superar ${minimoRequerido:F2} (precio ${PrecioActual:F2} + incremento ${MontoMinimoIncremento:F2}).";
        }
    }
}
