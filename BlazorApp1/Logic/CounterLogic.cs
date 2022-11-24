namespace BlazorApp1.Logic
{
    public class CounterLogic : ICounter
    {
        public int Count { get; set; } = 0;


        public void Increment()
        {
            Count++;
        }

    }
}