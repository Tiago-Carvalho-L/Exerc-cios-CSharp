namespace Exercicio007
{
    class TrocaLetras
    {
        public string Frase { get; set; }

        public TrocaLetras (string frase)
        {
            Frase = frase;
        }

        public string AlteraLetra()
        {
            return Frase.Replace('a', 'e');
        }
    }
}
