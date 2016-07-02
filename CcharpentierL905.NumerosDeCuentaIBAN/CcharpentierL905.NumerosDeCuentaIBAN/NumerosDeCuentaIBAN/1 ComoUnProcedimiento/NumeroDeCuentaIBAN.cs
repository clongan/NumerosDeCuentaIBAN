namespace ComoUnProcedimiento
{
    public class NumeroDeCuentaIBAN
    {
        public static string CalcularNumeroDeCuentaIBAN(string cuentaCliente)
        {
            const string letrasDelPais = "1227";
            const string codigoDePais = "00";
            string elRequerimiento = cuentaCliente + letrasDelPais + codigoDePais;

            decimal elRequerimientoComoNumero = decimal.Parse(elRequerimiento);
            decimal elNumeroVerificador = 98 - (elRequerimientoComoNumero % 97);

            string losDosDigitosVerificadores;
            if (elNumeroVerificador < 10)
            {
                losDosDigitosVerificadores = "0" + elNumeroVerificador;
            }
            else
            {
                losDosDigitosVerificadores = elNumeroVerificador.ToString();
            }

            return $"CR{losDosDigitosVerificadores}{cuentaCliente}";

        }
    }
}
