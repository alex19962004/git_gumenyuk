

namespace ConsoleApp_9__Software__3_
{
    public class Free : Software
    {
        public Free(string name, string producer) : base(name, producer)
        {
        }

        public override bool CanBeUsed(DateTime time)
        {
            return true;
        }

        public override string GetInfo()
        {
            return String.Format( $"{ Name + "\t" + Producer}");
        }
    }
}
