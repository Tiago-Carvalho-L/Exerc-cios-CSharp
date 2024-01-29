

namespace Exercicio005
{
    class MaiorNumero
    {
        public int NumeroUm { get; private set; }
        public int NumeroDois { get; private set; }
        public int NumeroTres { get; private set; }

        public MaiorNumero (int numeroUm, int numeroDois, int numeroTres)
        {
            NumeroUm = numeroUm;
            NumeroDois = numeroDois;
            NumeroTres = numeroTres;
        }

        public int VerificaNumero()
        {
            return (NumeroUm > NumeroDois && NumeroUm > NumeroTres) ? NumeroUm : (NumeroDois > NumeroTres) ? NumeroDois : NumeroTres; 
        }
    }
}
