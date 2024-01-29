namespace Exercicio008
{
    class AlteraFrase
    {
        public string Frase { get; set; }

        public AlteraFrase (string frase)
        {
            Frase = frase;
        }

        public string NovaFrase()
        {
            return Frase.Replace("agora", "depois");
        }
    }
}
