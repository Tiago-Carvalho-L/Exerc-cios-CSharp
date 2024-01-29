namespace Projeto001.Entities
{
    class Mammal : Animal
    {
        public int NumberOfBreasts { get; set; }

        public Mammal()
        {

        }

        public Mammal(string name, int age, int numberOfBreasts) : base (name, age)
        {
            NumberOfBreasts = numberOfBreasts;
        }

        public string Amamentar()
        {
            return "O mamífero está amamentando";
        }
    }
}
