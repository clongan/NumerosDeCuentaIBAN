namespace ComoUnProcedimiento
{
    public class NumeroDeCuentaIBAN
    {
        private static string codigoDePais;
        private static int elNumeroVerificador;
        private static string elRequerimiento;
        private static int elRequerimientoComoNumero;
        private static string letrasDelPais;

        public static string CalcularNumeroDeCuentaIBAN(string cuentaCliente)
        {
            letrasDelPais = "1227";
            codigoDePais = "00";
            elRequerimiento = cuentaCliente + letrasDelPais + codigoDePais;

            elRequerimientoComoNumero = int.Parse(elRequerimiento);
            elNumeroVerificador = 98 - (elRequerimientoComoNumero % 97);

            if (elNumeroVerificador < 10)
            {

            }
            return "";
        }
    }
}
