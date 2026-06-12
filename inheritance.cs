// Base class – contains shared code for all activities
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
    }
}
// Derived class – inherits from Activity using the colon ( : )
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "Relax by breathing in and out slowly.";
    }

    public void Run()
    {
        DisplayStartingMessage(); // inherited from Activity!
        // ... breathing-specific logic here
    }
}
