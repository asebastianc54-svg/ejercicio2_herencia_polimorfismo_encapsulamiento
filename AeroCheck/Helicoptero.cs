namespace AeroCheck
{
    public class Helicoptero : Aeronave
    {
        public int CiclosRotor { get; set; }

        public Helicoptero(double horasVuelo, int ciclosRotor) : base(horasVuelo)
        {
            CiclosRotor = ciclosRotor;
        }

        public override string GenerarReporteMantenimiento()
        {
            double indiceDesgaste = HorasVuelo * CiclosRotor;
            double umbral = 150000.0;
            if (indiceDesgaste > umbral)
            {
                return $"Helicóptero ({HorasVuelo:F1} hs x {CiclosRotor} ciclos = {indiceDesgaste:F0}): Alerta: Reemplazo de palas requerido.";
            }
            return $"Helicóptero ({HorasVuelo:F1} hs x {CiclosRotor} ciclos = {indiceDesgaste:F0}): palas dentro del rango operativo.";
        }
    }
}
