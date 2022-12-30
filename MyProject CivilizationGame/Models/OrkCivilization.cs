
namespace CivilizationGame.Models
{
    public class OrkCivilization : Civilization
    {
        private bool _hasDied;
        private int _maxPopulation;
        public OrkCivilization(
            int id,
            int population,
            int maxPopulation,
            DevelopmentPower developmentPower,
            Dictionary<InventionCategory, Invention> currentInventions)
            : base(id, population, CivilizationType.Ork, developmentPower, currentInventions)
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
                var populationNext = Population + Population * 0.4;
                if (populationNext >= _maxPopulation)   
                {
                    Console.WriteLine($"The {_type} won the game!!!");
                    return;
                }
                else
                    Population += (int)(Population * 0.4);
            }
        }

        public override void OnEpidemicEvent()                                                                   
        {
            Console.WriteLine($"The civilization {_type} don't have any {InventionCategory.Emergency} " +          
                              $"but they are so Strong. No damage by Epidemic");
        }

        protected virtual void OnHasDiedEvent()
        {
            _hasDied = true;
            Console.WriteLine($"The {_type} has died!!!");
        }
    }
}
