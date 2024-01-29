namespace Exercicio004
{
    class ClassificacaoIdade
    {
        public static string Classificao(int numero)
        {
            string faixaEtaria = "";
            switch (numero)
            {
                case <= 12:
                    faixaEtaria = "Criança";
                    break;
                case <= 19:
                    faixaEtaria = "Adolescente";
                    break;
                case <= 60:
                    faixaEtaria = "Adulto";
                    break;
                default:
                    faixaEtaria = "Idoso";
                    break;
            }

            return faixaEtaria;

        }
    }
}
