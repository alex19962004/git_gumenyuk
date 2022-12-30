using CivilizationGame.Models;

namespace CivilizationGame
{
    public class God
    {
        private List<Civilization> _civilizations = new();

        public void AddCivilization(Civilization civilization)
        {
            _civilizations.Add(civilization);
        }

        public async Task CreateWorld()
        {
            var tasks = new List<Task>();
            foreach (var civilization in _civilizations)
            {
                tasks.Add(civilization.Start());
                civilization.ReadyAttackEvent += OnReadyAttackEvent;                       
            }                     
            await Task.WhenAll(tasks);          
        }

        protected void OnReadyAttackEvent(Civilization civilization)
        {
            var opponentId = GetOpponentIndex(civilization.Id);

            if (civilization != _civilizations[opponentId])
                Fight(civilization, _civilizations[opponentId]);
            else if (_civilizations.Count == 1)
                Console.WriteLine($"The civilization {civilization._type} has no competitor to fight!");
        }

        private int GetOpponentIndex(int currentIndex)
        {
            var rand = new Random();
            var index = rand.Next(0, _civilizations.Count - 1);
            return index;
        }

        private async Task Fight(Civilization first, Civilization second)
        {
            var attackIteration = 0;            
            while (first.Population > 0 && second.Population > 0)
            {
                if (attackIteration % 2 == 0)
                {
                    var firstInc = first.PowerOfAttack();
                    var secondInc = second.PowerOfProtection();
                    Console.WriteLine($"The civilization {first._type} is attacking, {second._type} is on the defensive!!!");
                    Calculate(first, second, firstInc, secondInc);
                }
                else
                {
                    var firstInc = first.PowerOfProtection();
                    var secondInc = second.PowerOfAttack();
                    Console.WriteLine($"The civilization {second._type} is attacking, {first._type} is on the defensive!!!");
                    Calculate(second, first, secondInc, firstInc);    
                }
                attackIteration++;
                await Task.Delay(200);                                  
            }
        }

        private static void Calculate(Civilization first, Civilization second, int firstAttack, int secondCount)    
        {
            if (firstAttack > secondCount * 2)
            {
                first.Population -= (int)(second.Population * 0.5);
                second.Population = 0;
            }
            else if (secondCount > firstAttack * 2)
            {
                second.Population -= (int)(first.Population * 0.5);
                first.Population = 0;
            }
            else
            {
                first.Population -= (int)(secondCount * 0.5);
                second.Population -= (int)(firstAttack * 0.5);
            }
            if(first.Population <=0 && second.Population <=0)
                Console.WriteLine($"The civilization {first._type} and {second._type} - destroyed each other !!!");
            else if (first.Population <= 0)
                Console.WriteLine($"The civilization {second._type} has won {first._type} !!!");
            else if (second.Population <= 0)
                Console.WriteLine($"The civilization {first._type} has won {second._type} !!!");
        }

        public void DropCivilization(int id)
        {
            foreach (var civilization in _civilizations)
            {
                if (civilization.Id == id)
                {
                    civilization.Drop();                   
                    Console.WriteLine();
                    Console.WriteLine($"The civilization {civilization._type} is destroyed by God's decision!!!!!");
                }
            }
        }

        public void RaiseEpidemic(int id)
        {
            foreach (var civilization in _civilizations)
            {
                if (civilization.Id == id)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The civilization {civilization._type} provoked an epidemic by God's decision!!!!!");
                    civilization.OnEpidemicEvent();
                }
            }
        }
    }
}
