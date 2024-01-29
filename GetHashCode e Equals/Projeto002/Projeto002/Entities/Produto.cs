namespace Projeto002.Entities
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Produto))
            {
                return false;
            }

            Produto other = obj as Produto;
            return Id.Equals(other.Id) && Nome.Equals(other.Nome) && Preco.Equals(other.Preco);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Nome.GetHashCode() + Preco.GetHashCode();
        }
    }
}
