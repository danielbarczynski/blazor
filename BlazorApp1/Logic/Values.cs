namespace BlazorApp1.Logic
{
    public class Values : IValues // always use interface with dependency injection
    {
        public int Rand1 { get; set; }
        public int Rand2 { get; set; }


        public Values()
        {
            Rand1 = Random.Shared.Next(1, 1000);
            Rand2 = Random.Shared.Next(1, 1000);
        }

    }
}
