namespace ConFunciones
{
    public class NumeroDeCuentaIBAN
    {
        public static string CalcularNumeroDeCuentaIBAN(string cuentaCliente)
        {
            string losDosDigitosVerificadores = CalcularLosDosDigitosVerificadores(cuentaCliente);
            return ConcatenarNumeroDeCuentaIBAN(cuentaCliente, losDosDigitosVerificadores);

        }

        private static string CalcularLosDosDigitosVerificadores(string cuentaCliente)
        {
            decimal elRequerimientoComoNumero = ObtenerElRequerimiento(cuentaCliente);
            return DeterminarLosDigitosVerificadores(elRequerimientoComoNumero);
        }

        private static decimal ObtenerElRequerimiento(string cuentaCliente)
        {
            string elRequerimiento = DeterminarElRequerimiento(cuentaCliente);

            return decimal.Parse(elRequerimiento);
        }

        private static string DeterminarElRequerimiento(string cuentaCliente)
        {
            const string letrasDelPais = "1227";
            const string codigoDePais = "00";
            return cuentaCliente + letrasDelPais + codigoDePais;
        }

        private static string DeterminarLosDigitosVerificadores(decimal elRequerimientoComoNumero)
        {
            decimal elNumeroVerificador = CalcularElNumeroVerificador(elRequerimientoComoNumero);

            if (elNumeroVerificador < 10)
            {
                return ObtenerElDigitoVerificadorConUnDigitoComoTexto(elNumeroVerificador);
            }
            else
            {
                return ObtenerElDigitoVerificadorConDosDigitosComoTexto(elNumeroVerificador);
            }
        }

        private static decimal CalcularElNumeroVerificador(decimal elRequerimientoComoNumero)
        {
            return 98 - (elRequerimientoComoNumero % 97);
        }

        private static string ObtenerElDigitoVerificadorConUnDigitoComoTexto(decimal elNumeroVerificador)
        {
            return "0" + elNumeroVerificador;
        }

        private static string ObtenerElDigitoVerificadorConDosDigitosComoTexto(decimal elNumeroVerificador)
        {
            return elNumeroVerificador.ToString();
        }

        private static string ConcatenarNumeroDeCuentaIBAN(string cuentaCliente, string losDosDigitosVerificadores)
        {
            return $"CR{losDosDigitosVerificadores}{cuentaCliente}";
        }
    }
}
