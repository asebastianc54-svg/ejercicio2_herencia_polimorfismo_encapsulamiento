namespace AeroCheck
{
    public class AvionComercial : Aeronave
    {
        public int PasajerosMaximos { get; set; }

        public AvionComercial(double horasVuelo, int pasajerosMaximos) : base(horasVuelo)
        {
            PasajerosMaximos = pasajerosMaximos;
        }

        public override string GenerarReporteMantenimiento()
        {
            if (HorasVuelo > 10000)
            {
                return $"Avión comercial (cap. {PasajerosMaximos} pasajeros, {HorasVuelo:F1} hs): Revisión de Turbinas Tipo A.";
            }
            return $"Avión comercial (cap. {PasajerosMaximos} pasajeros, {HorasVuelo:F1} hs): mantenimiento de rutina al día.";
        }
    }
}
