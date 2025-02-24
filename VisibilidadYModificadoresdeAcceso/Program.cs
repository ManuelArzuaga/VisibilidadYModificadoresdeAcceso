namespace VisibilidadYModificadoresdeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuenta = new CuentaBancaria(1000);
            cuenta.Depositar(200);
            Console.WriteLine(cuenta.ObtenerSaldo());
            cuenta.Retirar(200);
            Console.WriteLine(cuenta.ObtenerSaldo());

        }
    }
}
