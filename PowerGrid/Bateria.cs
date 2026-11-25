namespace PowerGrid
{
    public class Bateria
    {
        private int porcentajeCarga;

        public int PorcentajeCarga
        {
            get => porcentajeCarga;
            set
            {
                if (value < 0)
                {
                    porcentajeCarga = 0;
                }
                else if (value > 100)
                {
                    porcentajeCarga = 100;
                }
                else
                {
                    porcentajeCarga = value;
                }
            }
        }

        public Bateria(int porcentajeCarga)
        {
            PorcentajeCarga = porcentajeCarga;
        }

        public virtual string ConsumirEnergia(int puntos)
        {
            if (puntos < 0)
            {
                return $"Puntos inválidos. Carga actual: {PorcentajeCarga}%.";
            }
            PorcentajeCarga -= puntos;
            return $"Batería consumió {puntos} puntos. Carga actual: {PorcentajeCarga}%.";
        }
    }
}
