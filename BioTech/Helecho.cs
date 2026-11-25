namespace BioTech
{
    public class Helecho : Planta
    {
        public int HumedadRequerida { get; set; }

        public Helecho(int edadDias, int saludInicial, int humedadRequerida) : base(edadDias, saludInicial)
        {
            HumedadRequerida = humedadRequerida;
        }

        public override string AplicarClima(string clima)
        {
            EdadDias += 1;
            string climaNormalizado = clima.Trim();

            if (climaNormalizado.Equals("Seco", StringComparison.OrdinalIgnoreCase))
            {
                Salud -= 20;
                return $"[Helecho] Clima seco (humedad requerida: {HumedadRequerida}%): perdió 20 de salud y requiere riego urgente. Salud actual: {Salud}.";
            }

            if (climaNormalizado.Equals("Lluvioso", StringComparison.OrdinalIgnoreCase))
            {
                Salud += 15;
                return $"[Helecho] Clima lluvioso favorable (humedad requerida: {HumedadRequerida}%). Salud actual: {Salud}.";
            }

            return $"[Helecho] Clima {climaNormalizado}. Salud actual: {Salud}.";
        }
    }
}
