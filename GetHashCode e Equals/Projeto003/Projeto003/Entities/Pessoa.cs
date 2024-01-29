namespace Projeto003.Entities
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }
        
        public Pessoa (int id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            if (!(obj is Pessoa))
            {
                return false;
            }

            Pessoa other = obj as Pessoa;
            return Id.Equals(other.Id) && Nome.Equals(other.Nome) && DataNascimento.Equals(other.DataNascimento);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Nome.GetHashCode() + DataNascimento.GetHashCode();
        }
    }
}
