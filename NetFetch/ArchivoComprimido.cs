namespace NetFetch
{
    public class ArchivoComprimido : Descarga
    {
        public bool EsSeguro { get; set; }

        public ArchivoComprimido(double tamanoMegas, bool esSeguro, int progresoInicial = 0) : base(tamanoMegas, progresoInicial)
        {
            EsSeguro = esSeguro;
        }

        public override string ActualizarProgreso(int megasDescargados)
        {
            if (TamanoMegas <= 0)
            {
                return "[ZIP] Tamaño de archivo inválido.";
            }
            double avancePorcentaje = (megasDescargados / TamanoMegas) * 100.0;
            Progreso += (int)Math.Round(avancePorcentaje);

            if (Progreso >= 100 && !EsSeguro)
            {
                Progreso = 0;
                return "Descarga abortada por amenaza detectada";
            }

            if (Progreso >= 100)
            {
                return $"[ZIP] Descarga completada al 100% ({TamanoMegas} MB). Archivo verificado.";
            }

            return $"[ZIP] Descargando paquete ({TamanoMegas} MB): {Progreso}%.";
        }
    }
}
