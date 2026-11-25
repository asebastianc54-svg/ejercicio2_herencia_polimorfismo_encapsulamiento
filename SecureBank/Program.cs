using SecureBank;

List<Transaccion> transacciones = new List<Transaccion>();

try
{
    transacciones.Add(new Transaccion("TOK12345"));
    transacciones.Add(new Transferencia("TRF98765", 250000m, "CBU-000111222"));
    transacciones.Add(new Transferencia("TRF55544", 750000m, "CBU-999888777"));
    transacciones.Add(new PagoServicio("PAG11223", 12000m, 5));
    transacciones.Add(new Transferencia("CORTA", 10000m, "CBU-000000000"));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error de validación de token: {ex.Message}");
}

foreach (Transaccion transaccion in transacciones)
{
    string resultado = transaccion.Procesar();
    Console.WriteLine(resultado);
}
