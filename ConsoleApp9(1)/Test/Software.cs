
namespace ConsoleApp9_1_.Test
{
    public abstract class Software
    {
        public string Name { get; set; }
        public string Producer { get; set; }

        public Software(string  name, string producer)
        {
            Name = name;
            Producer = producer;
        }

        public abstract string GetInfo();
        public abstract bool CanBeUsed(DateTime time);
    }
}
