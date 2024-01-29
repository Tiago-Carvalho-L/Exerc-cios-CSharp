namespace Exercicio003
{
    class RemoveEspacos
    {
        public string Frase { get; private set; }

        public RemoveEspacos(string frase)
        {
            Frase = frase;
        }

        public string EspacosBrancos()
        {
            return Frase.Trim();
        }
    }
}
