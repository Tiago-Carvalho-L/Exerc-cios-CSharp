namespace Exercicio004
{
    class EncontraPalavras
    {
        public string Frase { get; private set; }
        public string Palavra { get; private set; }

        public EncontraPalavras (string frase, string palavra)
        {
            Frase = frase;
            Palavra = palavra;
        }

        public int IndicePalavra()
        {
            return Frase.IndexOf(Palavra);
        }
    }
}
