using System;

namespace Exercicio007
{
    class OperacaoComTempo
    {
        public TimeSpan Tempo1 { get; set; }
        public TimeSpan Tempo2 { get; set;}

        public OperacaoComTempo (TimeSpan tempo1, TimeSpan tempo2)
        {
            Tempo1 = tempo1;
            Tempo2 = tempo2;
        }

        public TimeSpan Sum()
        {
            return Tempo1.Add(Tempo2);
        }

        public TimeSpan Sub()
        {
            return Tempo1.Subtract(Tempo2);
        }
    }
}
