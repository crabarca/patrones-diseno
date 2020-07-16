namespace Composite
{
    public class Task : IComposite
    {
        public int Duration { get; set; }

        public Task(int duration)
        {
            Duration = duration;
        }
    }
}