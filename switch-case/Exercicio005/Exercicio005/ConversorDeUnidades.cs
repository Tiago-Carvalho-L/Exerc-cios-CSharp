namespace Exercicio005
{
    class ConversorDeUnidades
    {
        public int Conversao { get; set; }

        public double Valor { get; set; }

        public ConversorDeUnidades() { }

        public ConversorDeUnidades(int conversao, double valor)
        {
            Conversao = conversao;
            Valor = valor;
        }

        public double CentimetrosMetros()
        {
            return Valor / 100.0;
        }

        public double GramasQuilos()
        {
            return Valor / 1000.0;
        }

        public double MililitrosLitros()
        {
            return Valor / 1000.0;
        }

        public double TipoDeConversao()
        {
            double tipo = 0;
            switch (Conversao)
            {
                case 1:
                    tipo = CentimetrosMetros();
                    break;
                case 2:
                    tipo = GramasQuilos();
                    break;
                default:
                    tipo = MililitrosLitros();
                    break;
            }
            return tipo;
        }
    }
}
