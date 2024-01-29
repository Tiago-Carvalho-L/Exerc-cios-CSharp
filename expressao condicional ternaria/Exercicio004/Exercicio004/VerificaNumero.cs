namespace Exercicio004
{
    class VerificaNumero
    {
        public static string Verificacao(int numero)
        {
            return (numero == 0) ? "zero" : (numero > 0) ? "positivo" : "negativo";
        }
    }
}
