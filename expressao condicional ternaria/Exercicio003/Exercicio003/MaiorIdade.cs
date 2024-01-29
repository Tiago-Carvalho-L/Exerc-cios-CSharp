namespace Exercicio003
{
    class MaiorIdade
    {
        public int Idade { get; private set; }

        public MaiorIdade(int idade)
        {
            Idade = idade;
        }

        public string ClassificacaoEtaria()
        {
            return(Idade >= 18) ? "Maior de idade" : "Menor de idade";
        }
    }
}
