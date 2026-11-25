namespace BioTech
{
    public class Planta
    {
        private int salud;

        public int EdadDias { get; set; }

        public int Salud
        {
            get => salud;
            set
            {
                if (value < 0)
                {
                    salud = 0;
                }
                else if (value > 100)
                {
                    salud = 100;
                }
                else
                {
                    salud = value;
                }
            }
        }

        public Planta(int edadDias, int saludInicial)
        {
            EdadDias = edadDias;
            Salud = saludInicial;
        }

        public virtual string AplicarClima(string clima)
        {
            EdadDias += 1;
            return $"Planta ({EdadDias} días) bajo clima {clima}. Salud: {Salud}.";
        }
    }
}
