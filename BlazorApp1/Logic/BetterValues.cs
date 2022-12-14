namespace BlazorApp1.Logic
{
    public class BetterValues : IValues // always use interface with dependency injection
    {
        public int Rand1 { get; set; }
        public int Rand2 { get; set; }


        public BetterValues()
        {
            Rand1 = Random.Shared.Next(1000, 10000);
            Rand2 = Random.Shared.Next(1000, 10000);
        }

    }
}
