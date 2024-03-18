namespace Program;

public class OverfillException : Exception
{
    public OverfillException(int severity, string message) : base(message)
    {
        
    }
}