namespace AeroCheck
{
    public class Aeronave
    {
        private double horasVuelo;

        public double HorasVuelo
        {
            get => horasVuelo;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Las horas de vuelo no pueden ser negativas.");
                }
                horasVuelo = value;
            }
        }

        public Aeronave(double horasVuelo)
        {
            HorasVuelo = horasVuelo;
        }

        public virtual string GenerarReporteMantenimiento()
        {
            return $"Aeronave con {HorasVuelo:F1} horas de vuelo: inspección general programada.";
        }
    }
}
