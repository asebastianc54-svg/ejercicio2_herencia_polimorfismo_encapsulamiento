using FactoryAlert;

List<Sensor> sensores = new List<Sensor>
{
    new SensorTemperatura("TEMP-01", 80.0),
    new SensorPresion("PRES-02", new double[] { 10.0, 14.5 })
};

double lecturaCritica = 96.5;

foreach (Sensor sensor in sensores)
{
    string reporte = sensor.EvaluarLectura(lecturaCritica);
    Console.WriteLine(reporte);
}
