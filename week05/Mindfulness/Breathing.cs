public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") {}

    protected override void RunActivity()
    {
        int cycleDuration = 6; // e.g., 3s in, 3s out
        int cycles = _duration / cycleDuration;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Now breathe out...");
            Countdown(3);
        }
    }
}
