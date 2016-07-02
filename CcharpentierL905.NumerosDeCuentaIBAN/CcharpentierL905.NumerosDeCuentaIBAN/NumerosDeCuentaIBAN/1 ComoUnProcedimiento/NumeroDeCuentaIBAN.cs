namespace ComoUnProcedimiento
{
    public class NumeroDeCuentaIBAN
    {
        private static string codigoDePais;
        private static string elRequerimiento;
        private static string letrasDelPais;

        public static string CalcularNumeroDeCuentaIBAN(string cuentaCliente)
        {
            letrasDelPais = "1227";
            codigoDePais = "00";
            elRequerimiento = cuentaCliente + letrasDelPais + codigoDePais;

            return "";
        }
    }
}
