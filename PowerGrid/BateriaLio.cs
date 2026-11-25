namespace PowerGrid
{
    public class BateriaLio : Bateria
    {
        private bool ahorroEnergiaActivo = false;

        public BateriaLio(int porcentajeCarga) : base(porcentajeCarga)
        {
        }

        public override string ConsumirEnergia(int puntos)
        {
            if (puntos < 0)
            {
                return $"[Li-Ion] Puntos inválidos. Carga: {PorcentajeCarga}%.";
            }

            int consumoAplicado = ahorroEnergiaActivo ? Math.Max(1, puntos / 2) : puntos;
            int cargaAntes = PorcentajeCarga;
            PorcentajeCarga -= consumoAplicado;

            if (PorcentajeCarga == 0)
            {
                bool eraNuevoAgotamiento = !ahorroEnergiaActivo || cargaAntes > 0;
                ahorroEnergiaActivo = true;
                if (eraNuevoAgotamiento)
                {
                    return $"[Li-Ion] Carga agotada (0%). Se activa modo de \"Ahorro de energía\" para reducir el consumo a la mitad en la siguiente llamada.";
                }
                return $"[Li-Ion] En modo de \"Ahorro de energía\" (consumo reducido a {consumoAplicado}). Carga: 0%.";
            }

            if (ahorroEnergiaActivo)
            {
                return $"[Li-Ion] Modo de \"Ahorro de energía\" activo: consumió {consumoAplicado} puntos. Carga restante: {PorcentajeCarga}%.";
            }

            return $"[Li-Ion] Consumió {consumoAplicado} puntos exactos. Carga restante: {PorcentajeCarga}%.";
        }
    }
}
