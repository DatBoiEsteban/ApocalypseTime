public abstract class Event
{
    public float Duration; // In seconds
    public float Scale; // Event difficulty multiplier
    public int InitialDifficulty; // Ranking Difficulty
    public string Message; // Event start message

    public abstract void runEvent();
}  
