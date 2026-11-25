namespace FactoryAlert
{
    public class SensorPresion : Sensor
    {
        public List<double> HistorialLecturas { get; set; } = new List<double>();

        public SensorPresion(string id, IEnumerable<double>? lecturasIniciales = null, string estado = "Ok") : base(id, estado)
        {
            if (lecturasIniciales != null)
            {
                HistorialLecturas.AddRange(lecturasIniciales);
            }
        }

        public override string EvaluarLectura(double valor)
        {
            HistorialLecturas.Add(valor);
            int n = HistorialLecturas.Count;
            bool ultimasTresAscendentes = n >= 3 &&
                HistorialLecturas[n - 3] < HistorialLecturas[n - 2] &&
                HistorialLecturas[n - 2] < HistorialLecturas[n - 1];

            if (ultimasTresAscendentes)
            {
                Estado = "Alerta";
                return $"[{Id}] Presión {valor:F1} bar -> Tendencia inestable (estado: {Estado}).";
            }

            Estado = "Ok";
            return $"[{Id}] Presión {valor:F1} bar estable (estado: {Estado}).";
        }
    }
}
