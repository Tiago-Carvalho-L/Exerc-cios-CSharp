
namespace Exercicio010
{
    class ValidadorDeCampo
    {
        public string Nome { get; set; }

        public ValidadorDeCampo(string nome)
        {
            Nome = nome;
        }

        public bool Validado()
        {
            return String.IsNullOrWhiteSpace(Nome);
        }

        public string Retorna()
        {
            if (Validado())
            {
                return "Nome inválido";
            }
            else
            {
                return "Nome válido";
            }
        }
    }
}
