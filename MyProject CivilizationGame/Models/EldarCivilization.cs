
namespace CivilizationGame.Models
{
    public class EldarCivilization : Civilization
    {
        private bool _hasDied;
        private int _maxPopulation;
        public EldarCivilization(
            int id, 
            int population, 
            int maxPopulation,
            DevelopmentPower developmentPower, 
            Dictionary<InventionCategory, Invention> currentInventions) 
            : base(id, population, CivilizationType.Eldar, developmentPower, currentInventions)
        {
            _maxPopulation = maxPopulation;
            HasDiedEvent += OnHasDiedEvent;
        }

        public override async Task Start()
        {
            Console.WriteLine($"Start {_type} with population " + Population);

            while (!_hasDied)
            {
                RaiseIncident();
                if (Population < 0)
                    break;

                Console.WriteLine($"The {_type} current population " + Population);

                await Task.Delay(500);
                var populationNext = Population + Population * 0.45;
                if (populationNext >= _maxPopulation)
                {
                    Console.WriteLine($"The {_type} won the game!!!");
                    return;
                }
                else
                    Population += (int)(Population * 0.45);
            }
        }
        protected virtual void OnHasDiedEvent()
        {
            _hasDied = true;
            Console.WriteLine($"The {_type} has died!!!");
        }

        /*public override int PowerOfProtection()
        {
            return Population * 1000;
        }*/
    }
}
