
namespace CivilizationGame.Models
{
    public class DevelopmentPower
    {
        public int From { get; }
        public int To { get; }

        public DevelopmentPower(int from, int to)
        {
            From = from;
            To = to;
        }
    }
}
