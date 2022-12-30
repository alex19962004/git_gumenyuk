
namespace CivilizationGame.Models
{
    public class TyranidCivilization : Civilization
    {
        private bool _hasDied;
        private int _maxPopulation;
        public TyranidCivilization(
            int id,
            int population,
            int maxPopulation,
            DevelopmentPower developmentPower,
            Dictionary<InventionCategory, Invention> currentInventions)
            : base(id, population, CivilizationType.Tyranid, developmentPower, currentInventions)
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
                var populationNext = Population + Population * 0.5;
                if (populationNext >= _maxPopulation)
                {
                    Console.WriteLine($"The {_type} won the game!!!");
                    return;
                }
                else
                    Population += (int)(Population * 0.5);
            }
        }

        protected virtual void OnHasDiedEvent()
        {
            _hasDied = true;
            Console.WriteLine($"The {_type} has died!!!");
        }

       /* public override int PowerCount()
        {
            int incremental = 1;
            if (_currentInventions.ContainsKey(InventionCategory.TechnicalThings)
                &&  _currentInventions[InventionCategory.TechnicalThings].Contains(InventionType.Engine)
                &&  _currentInventions[InventionCategory.TechnicalThings].Contains(InventionType.Wheel))
                incremental += 300;
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Gun)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Count))
                incremental += 100;
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                     && _currentInventions[InventionCategory.War].Contains(InventionType.Count))
                incremental += 30;
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                     && _currentInventions[InventionCategory.War].Contains(InventionType.Sword))
                incremental += 15;

            return Population * incremental * 20;
        }*/
    }
}
