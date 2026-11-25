namespace PowerGrid
{
    public class BateriaSolar : Bateria
    {
        public double EficienciaPanel { get; set; }

        public BateriaSolar(int porcentajeCarga, double eficienciaPanel) : base(porcentajeCarga)
        {
            EficienciaPanel = eficienciaPanel;
        }

        public override string ConsumirEnergia(int puntos)
        {
            if (puntos < 0)
            {
                return $"[Solar] Puntos inválidos. Carga: {PorcentajeCarga}%.";
            }

            int recuperacion = (int)Math.Round(EficienciaPanel * 20.0);
            int gastoNeto = Math.Max(0, puntos - recuperacion);
            PorcentajeCarga = PorcentajeCarga - puntos + recuperacion;

            return $"[Solar] Solicitó {puntos} pts, recuperó {recuperacion} pts por eficiencia ({EficienciaPanel:P0}). Gasto neto real: {gastoNeto} pts. Carga: {PorcentajeCarga}%.";
        }
    }
}
