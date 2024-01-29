namespace Exercicio001
{
    class Lower
    {
        public string Frase { get; private set; }

        public Lower (string frase)
        {
            Frase = frase;
        }

        public string FraseMinuscula()
        {
            return Frase.ToLower();
        }
    }
}
