
namespace CivilizationGame.Models
{
    public enum InventionCategory
    {
        Emergency = 1,
        Food = 2,
        War = 3,
        TechnicalThings = 4,
        Evolution = 5,       
    }

    public enum InventionType       //order invention
    {
        // Emergency
        Chemistry,
        Pill,
        
        // Food
        Flour,
        Storage,
        
        // War
        Sword,
        Count,
        Gun,

        // Technical things
        Instruments,
        Electricity,
        Wheel,
        Engine,
      
        // Evolution
        Science,
        Technologies,
        Industry,
        
        // Buildings
        Forge,
        Bake,
        Hospital,
    }

    public class Invention
    {
        public InventionCategory Category { get; }
        public List<InventionType> InventionTypes { get; }

        public Invention(InventionCategory category, List<InventionType> inventionTypes)
        {
            Category = category;
            InventionTypes = inventionTypes;
        }

        public void Add(InventionType inventionType)
        {
            InventionTypes.Add(inventionType);
        }

        public bool Contains(InventionType inventionType)
        {
            return InventionTypes.Contains(inventionType);
        }

        public InventionType GetNext(InventionType currentType)
        {
            for (var i = 0; i < InventionTypes.Count; i++)
            {
                if (currentType != InventionTypes[i]) continue;

                if (i + 1 < InventionTypes.Count)
                    return InventionTypes[i + 1];
                break;
            }

            return InventionTypes.First();
        }

        public InventionType Last()
        {
            return InventionTypes.Last();
        }
    }

    public static class InventionDab
    {
        public static readonly Dictionary<InventionCategory, Invention> Inventions = new()
    {
        {
            InventionCategory.Emergency,
            new Invention(InventionCategory.Emergency,
            new List<InventionType>
            {
               InventionType.Chemistry,
               InventionType.Pill
            })
        },
        {
            InventionCategory.Food,
            new Invention(InventionCategory.Food,
            new List<InventionType>
            {
               InventionType.Flour,
               InventionType.Storage
            })
        },
        {
            InventionCategory.War,
            new Invention(InventionCategory.War,
            new List<InventionType>
            {
                InventionType.Sword,
                InventionType.Count,
                InventionType.Gun
            })
        },
        {
            InventionCategory.TechnicalThings,
            new Invention(InventionCategory.TechnicalThings,
            new List<InventionType>
            {
                InventionType.Instruments,
                InventionType.Electricity,
                InventionType.Wheel,
                InventionType.Engine,
            })
        },
        {
            InventionCategory.Evolution,
            new Invention(InventionCategory.Evolution,
            new List<InventionType>
            {
                InventionType.Science,
                InventionType.Technologies,
                InventionType.Industry       
            })
        }
    };
    }
}
