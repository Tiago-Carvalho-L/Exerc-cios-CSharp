

namespace Exercicio002
{
    class MediaFinal
    {
        public double NotaUm { get; private set; }
        public double NotaDois { get; private set; }

        public MediaFinal (double notaUm, double notaDois)
        {
            NotaUm = notaUm;
            NotaDois = notaDois;
        }

        public double Media()
        {
            return (NotaUm + NotaDois) / 2;
        }

        public string AprovadoOuReprovado()
        {
            return (Media() >= 5.0) ? "Aluno APROVADO" : "Aluno REPROVADO";
        }
    }
}
