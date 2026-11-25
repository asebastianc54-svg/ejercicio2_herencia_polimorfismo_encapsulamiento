using PowerGrid;

List<Bateria> baterias = new List<Bateria>
{
    new BateriaLio(60),
    new BateriaSolar(75, 0.50)
};

for (int ronda = 1; ronda <= 3; ronda++)
{
    Console.WriteLine($"--- Ronda {ronda} ---");
    foreach (Bateria bateria in baterias)
    {
        string estado = bateria.ConsumirEnergia(40);
        Console.WriteLine(estado);
    }
}
