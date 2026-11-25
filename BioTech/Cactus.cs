namespace BioTech
{
    public class Cactus : Planta
    {
        public Cactus(int edadDias, int saludInicial) : base(edadDias, saludInicial)
        {
        }

        public override string AplicarClima(string clima)
        {
            EdadDias += 1;
            string climaNormalizado = clima.Trim();

            if (climaNormalizado.Equals("Lluvioso", StringComparison.OrdinalIgnoreCase))
            {
                Salud -= 25;
                return $"[Cactus] Clima lluvioso: la salud bajó porque se ahoga. Salud actual: {Salud}.";
            }

            if (climaNormalizado.Equals("Desértico", StringComparison.OrdinalIgnoreCase) ||
                climaNormalizado.Equals("Desertico", StringComparison.OrdinalIgnoreCase))
            {
                Salud += 15;
                return $"Cactus en su hábitat óptimo. Salud actual: {Salud}.";
            }

            return $"[Cactus] Clima {climaNormalizado} sin cambios drásticos. Salud actual: {Salud}.";
        }
    }
}
