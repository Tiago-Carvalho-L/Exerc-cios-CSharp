namespace Exercicio009
{
    class VerificaCampo
    {
        public string Nome { get; private set; }

        public VerificaCampo(string nome)
        {
            Nome = nome;
        }

        public bool Verificacao()
        {
            return String.IsNullOrEmpty(Nome);
        }

        public string Resposta()
        {
            if (Verificacao())
            {
                return "Nome inválido";
            }
            else
            {
                return "Nome aceito";
            }
        }
    }
}
