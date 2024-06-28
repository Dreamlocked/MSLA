namespace MLSA.Domain.Entities.Exceptions;
public class CancellationException : Exception
{
    public CancellationException() { }
    public CancellationException(string message) : base(message) { }
    public CancellationException(string message, Exception innerException) : base(message, innerException) { }
}
