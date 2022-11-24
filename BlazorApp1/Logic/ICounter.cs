namespace BlazorApp1.Logic
{
    public interface ICounter
    {
        int Count { get; set; }

        void Increment();
    }
}