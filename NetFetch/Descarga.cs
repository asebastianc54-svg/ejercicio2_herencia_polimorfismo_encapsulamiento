namespace NetFetch
{
    public class Descarga
    {
        private int progreso;

        public double TamanoMegas { get; set; }

        public int Progreso
        {
            get => progreso;
            set
            {
                if (value < 0)
                {
                    progreso = 0;
                }
                else if (value > 100)
                {
                    progreso = 100;
                }
                else
                {
                    progreso = value;
                }
            }
        }

        public Descarga(double tamanoMegas, int progresoInicial = 0)
        {
            TamanoMegas = tamanoMegas;
            Progreso = progresoInicial;
        }

        public virtual string ActualizarProgreso(int megasDescargados)
        {
            if (TamanoMegas <= 0)
            {
                return "Tamaño de archivo inválido.";
            }
            double avancePorcentaje = (megasDescargados / TamanoMegas) * 100.0;
            Progreso += (int)Math.Round(avancePorcentaje);
            return $"Descarga estándar ({TamanoMegas} MB): progreso al {Progreso}%.";
        }
    }
}
