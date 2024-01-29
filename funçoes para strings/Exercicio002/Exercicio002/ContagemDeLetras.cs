namespace Exercicio002
{
    class ContagemDeLetras
    {
        public string Frase { get; private set; }

        public ContagemDeLetras(string frase)
        {
            Frase = frase;
        }

        public int ContagemDeA()
        {
            int a = 0;
            for (int i = 0; i < Frase.Length; i++)
            {
                if (Frase[i] == 'a' || Frase[i] == 'A')
                {
                    a++;
                }
            }

            return a;
        }
    }
}

