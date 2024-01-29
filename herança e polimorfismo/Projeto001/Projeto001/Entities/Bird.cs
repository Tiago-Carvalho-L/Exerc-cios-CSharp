namespace Projeto001.Entities
{
    class Bird : Animal
    {
        public double EnvergaduraDasAsas { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int age, double envergaduraDasAsas) : base (name, age)
        {
            EnvergaduraDasAsas = envergaduraDasAsas;
        }

        public string Voar()
        {
            return "A ave está voando";
        }
    }
}
