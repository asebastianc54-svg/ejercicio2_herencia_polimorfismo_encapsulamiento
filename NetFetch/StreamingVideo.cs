namespace NetFetch
{
    public class StreamingVideo : Descarga
    {
        public int BufferMinimo { get; set; }

        public StreamingVideo(double tamanoMegas, int bufferMinimo, int progresoInicial = 0) : base(tamanoMegas, progresoInicial)
        {
            BufferMinimo = bufferMinimo;
        }

        public override string ActualizarProgreso(int megasDescargados)
        {
            if (TamanoMegas <= 0)
            {
                return "[Video] Tamaño de video inválido.";
            }
            double avancePorcentaje = (megasDescargados / TamanoMegas) * 100.0;
            Progreso += (int)Math.Round(avancePorcentaje);

            if (Progreso < BufferMinimo)
            {
                return "Cargando... Video pausado";
            }
            return $"[Video] Reproducción fluida. Buffer: {Progreso}% (mínimo requerido: {BufferMinimo}%).";
        }
    }
}
