namespace Exercicio006
{
    class SubPalavra
    {
        public string Palavra { get; set; }
        public int Inicio { get; set; }
        public int Tamanho { get; set; }

        public SubPalavra (string palavra, int inicio, int tamanho)
        {
            Palavra = palavra;
            Inicio = inicio;
            Tamanho = tamanho;
        }

        public string NovaPalavra()
        {
            return Palavra.Substring(Inicio, Tamanho);
        }
    }
}
