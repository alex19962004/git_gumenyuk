
namespace CivilizationGame.Models
{
    public abstract class Civilization
    {
        public delegate void CivilizationEventHandler();
        public delegate void CivilizationExternalHandler(Civilization civilization);  

        private event CivilizationEventHandler FamineEvent;
        private event CivilizationEventHandler EpidemicEvent;
        private event CivilizationEventHandler InventionEvent;

        public event CivilizationEventHandler HasDiedEvent;                  
        public event CivilizationExternalHandler ReadyAttackEvent;

        public int Id { get; }
        private int _population;
        private readonly DevelopmentPower _developmentPower;
        private Dictionary<InventionCategory, Invention> _currentInventions;                                                                                                            

        public CivilizationType _type { get; }
       
        public int Population {                                                            
            get { return _population; } 
            set { _population = value; }
        }

        protected Civilization(
            int id,
            int population,            
            CivilizationType type,
            DevelopmentPower developmentPower,
            Dictionary<InventionCategory, Invention> currentInventions)
        {
            Id = id;
            _population = population;            
            _type = type;
            _developmentPower = developmentPower;
            _currentInventions = currentInventions;

            InitializeCurrentInventions();

            FamineEvent += OnFamineEvent;
            EpidemicEvent += OnEpidemicEvent;
            InventionEvent += OnInventionEvent;
        }

        private void InitializeCurrentInventions()
        {          
            _currentInventions.Add(InventionCategory.Emergency,
                new Invention(InventionCategory.Emergency, new List<InventionType>()));
            _currentInventions.Add(InventionCategory.Food,
                new Invention(InventionCategory.Food, new List<InventionType>()));
            _currentInventions.Add(InventionCategory.War,
                new Invention(InventionCategory.War, new List<InventionType>()));
            _currentInventions.Add(InventionCategory.TechnicalThings,
                new Invention(InventionCategory.TechnicalThings, new List<InventionType>()));
            _currentInventions.Add(InventionCategory.Evolution,
                new Invention(InventionCategory.Evolution, new List<InventionType>()));
        }
       
        protected void RaiseIncident()
        {
            switch (Population)
            {
                case <= 1:
                    HasDiedEvent();
                    return;
                case >=  30000:                    
                    ReadyAttackEvent(this);
                    return;
            }

            var rnd = new Random();                                 
            var incidentCoefficient = rnd.Next(1,100);
            var incidentNumber = 0;                     //  var incidentNumber = rnd.Next(1,3);
            if (incidentCoefficient <= 20)           
                 incidentNumber = 1;            
            else if(incidentCoefficient >20 && incidentCoefficient <= 40)           
                 incidentNumber = 2;
            else if(incidentCoefficient > 40 && incidentCoefficient <= 100 )
                 incidentNumber = 3;
                                     
            switch ((IncidentType)incidentNumber)
            {
                case IncidentType.Epidemic:
                    Console.WriteLine($"The civilization {_type} has got {IncidentType.Epidemic}");
                    EpidemicEvent.Invoke();
                    break;
                case IncidentType.Famine:
                    Console.WriteLine($"The civilization {_type} has got {IncidentType.Famine}");
                    FamineEvent.Invoke();
                    break;
                case IncidentType.Invention:
                    Console.WriteLine($"The civilization {_type} has got {IncidentType.Invention}");
                    InventionEvent.Invoke();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public abstract Task Start();

        public virtual void OnEpidemicEvent()
        {
            if (_currentInventions.ContainsKey(InventionCategory.Emergency))
            {
                if (_currentInventions[InventionCategory.Emergency].Contains(InventionType.Pill))
                {
                    Console.WriteLine($"The civilization {_type} has applied {InventionCategory.Emergency} " +
                                      $"with {InventionType.Pill} and skip epidemic");
                    return;
                }
                if (_currentInventions[InventionCategory.Emergency].Contains(InventionType.Chemistry))
                {
                    Population -= (int)(Population * 0.1);
                    Console.WriteLine($"The civilization {_type} has applied {InventionCategory.Emergency} " +
                                      $"with {InventionType.Chemistry} and Population -10%");
                    return;
                }
            }
            Population -= (int)(Population * 0.2);
            Console.WriteLine($"The civilization {_type} don't have any {InventionCategory.Emergency} " +
                              $"and Population -20%");
        }

        protected virtual void OnFamineEvent()
        {
            if (_currentInventions.ContainsKey(InventionCategory.Food))
            {
                if (_currentInventions[InventionCategory.Food].InventionTypes.Contains(InventionType.Flour)
                    && _currentInventions[InventionCategory.Food].Contains(InventionType.Storage))
                {
                    Console.WriteLine($"The civilization {_type} has applied {InventionCategory.Food} " +
                                      $"with {InventionType.Flour} and {InventionType.Storage} for skipping famine");
                    return;
                }

                if (_currentInventions[InventionCategory.Food].Contains(InventionType.Flour))
                {
                    Population -= (int)(Population * 0.1);
                    Console.WriteLine($"The civilization {_type} has applied {InventionCategory.Food} " +
                                      $"with {InventionType.Flour} for -20% population");
                    return;
                }
            }
            Population -= (int)(Population * 0.15);
            Console.WriteLine($"The civilization {_type} don't have any {InventionCategory.Food} " +
                              $"and Population -15%");
        }

        protected virtual void OnInventionEvent()
        {
            var rnd = new Random();
            var improvement = rnd.Next(_developmentPower.From, _developmentPower.To + 1);      //1-5            

            if (improvement > InventionDab.Inventions.Count)                                  // all inventions are 5
            {
                Console.WriteLine($"The civilization {_type} has tried to learn invention but could not");
                return;
            }
            var improvmentCategory = (InventionCategory)improvement;                  
            var currentCategory = InventionDab.Inventions[improvmentCategory];
            InventionType nextInventionType;
            if (_currentInventions[currentCategory.Category].InventionTypes.Count > 0)
                nextInventionType = currentCategory.GetNext(_currentInventions[currentCategory.Category].Last());
            else
                nextInventionType = InventionDab.Inventions[improvmentCategory].InventionTypes.First();

            _currentInventions[currentCategory.Category].Add(nextInventionType);

            Console.WriteLine($"The civilization {_type} has learnt {nextInventionType} on category {currentCategory.Category}");
        }

        public virtual int PowerOfAttack()
        {
            int incremental = 1;
            if (_currentInventions.ContainsKey(InventionCategory.War)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Gun))
                incremental *= 100;
            
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Sword))
                incremental *= 30;

            return Population * incremental;
        }

        public virtual int PowerOfProtection()                                         
        {
            var countForCategoryWar = CalculateCountForCategoryWar();
            var countForCategoryTechnicalThings = CalculateCountForCategoryTechnicalThings();
            var countForCategoryEvolution = CalculateCountForCategoryEvolution();

            return Population * countForCategoryWar * countForCategoryTechnicalThings * countForCategoryEvolution;
        }

        private int CalculateCountForCategoryWar()
        {
            int incremental = 1;
            if (_currentInventions.ContainsKey(InventionCategory.War)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Gun)
                && _currentInventions[InventionCategory.War].Contains(InventionType.Count))
                incremental *= 100;
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                     && _currentInventions[InventionCategory.War].Contains(InventionType.Count))
                incremental *= 30;
            else if (_currentInventions.ContainsKey(InventionCategory.War)
                     && _currentInventions[InventionCategory.War].Contains(InventionType.Sword))
                incremental *= 15;
            return incremental;
        }
        private int CalculateCountForCategoryTechnicalThings()
        {
            int incremental = 1;
            if (_currentInventions.ContainsKey(InventionCategory.TechnicalThings)
                && _currentInventions[InventionCategory.TechnicalThings].Contains(InventionType.Instruments))
                incremental *= 10;
            else if (_currentInventions.ContainsKey(InventionCategory.TechnicalThings)
                && _currentInventions[InventionCategory.TechnicalThings].Contains(InventionType.Electricity))
                incremental *= 20;
            return incremental;
        }

        private int CalculateCountForCategoryEvolution()
        {
            int incremental = 1;
            if (_currentInventions.ContainsKey(InventionCategory.Evolution)
                && _currentInventions[InventionCategory.Evolution].Contains(InventionType.Science))
                incremental *= 50;
            else if (_currentInventions.ContainsKey(InventionCategory.Evolution)
                && _currentInventions[InventionCategory.Evolution].Contains(InventionType.Technologies))
                incremental *= 60;
            return incremental;
        }

        public virtual void Drop()
        {
            Population = 0;
        }       
    }       
}
