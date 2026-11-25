namespace FactoryAlert
{
    public class SensorTemperatura : Sensor
    {
        public double LimiteCritico { get; set; }

        public SensorTemperatura(string id, double limiteCritico, string estado = "Ok") : base(id, estado)
        {
            LimiteCritico = limiteCritico;
        }

        public override string EvaluarLectura(double valor)
        {
            if (valor > LimiteCritico)
            {
                Estado = "Peligro";
                return $"[{Id}] TEMPERATURA CRÍTICA ({valor:F1} C > {LimiteCritico:F1} C). ESTADO: {Estado}".ToUpper();
            }
            Estado = "Ok";
            return $"[{Id}] Temperatura normal ({valor:F1} C). Estado: {Estado}.";
        }
    }
}
