namespace EBid
{
    public class SubastaRelampago : Subasta
    {
        public int TiempoRestanteSegundos { get; set; }

        public SubastaRelampago(decimal precioActual, int tiempoRestanteSegundos) : base(precioActual)
        {
            TiempoRestanteSegundos = tiempoRestanteSegundos;
        }

        public override string RegistrarOferta(decimal oferta)
        {
            if (oferta <= PrecioActual)
            {
                return $"[Relámpago] Oferta de ${oferta:F2} rechazada. Precio actual: ${PrecioActual:F2} ({TiempoRestanteSegundos}s restantes).";
            }

            PrecioActual = oferta;
            if (TiempoRestanteSegundos < 10)
            {
                TiempoRestanteSegundos += 30;
                return $"[Relámpago] ¡Oferta de último segundo! Tiempo extendido a {TiempoRestanteSegundos}s. Nuevo precio: ${PrecioActual:F2}.";
            }

            return $"[Relámpago] Oferta de ${oferta:F2} aceptada. Nuevo precio: ${PrecioActual:F2} ({TiempoRestanteSegundos}s restantes).";
        }
    }
}
