namespace Exercicio005
{
    class Subpalavra
    {
        public string Palavra { get; set; }
        public int Indice { get; set; }

        public Subpalavra(string palavra, int indice)
        {
            Palavra = palavra;
            Indice = indice;
        }

        public string NovaPalavra()
        {
            return Palavra.Substring(Indice);
        }
    }
}
