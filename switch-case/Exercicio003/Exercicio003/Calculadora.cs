namespace Exercicio003
{
    class Calculadora
    {
        public double NumeroUm { get; set; }
        public double NumeroDois { get; set; }
        public string Operador { get; set; }

        public Calculadora (double numeroUm, double numeroDois, string operador)
        {
            NumeroUm = numeroUm;
            NumeroDois = numeroDois;
            Operador = operador;
        }

        public double Soma()
        {
            return NumeroUm + NumeroDois;
        }

        public double Subtracao()
        {
            return NumeroUm - NumeroDois;
        }

        public double Multiplicacao()
        {
            return NumeroUm * NumeroDois;
        }

        public double Divisao()
        {
            return NumeroUm / NumeroDois;
        }

        public double Operacao()
        {
            double conta = 0.0;
            switch (Operador)
            {
                case "+":
                    conta = Soma();
                    break;
                case "-": 
                    conta = Subtracao();
                    break;
                case "*":
                    conta = Multiplicacao();
                    break;
                default:
                    conta = Divisao();
                    break;
            }

            return conta;
        }
    }
}
