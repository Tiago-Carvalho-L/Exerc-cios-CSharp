namespace Exercicio006
{
    class ConversorDeMoeda
    {
        public static double iof = 6;

        public static double ValorPago (double cotacao, double quantidade)
        {
            double conversao = cotacao * quantidade;
            conversao += conversao * (iof / 100.0);
            return conversao;
        }
    }
}
