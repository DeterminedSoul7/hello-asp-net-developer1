namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// A record representing the response for a greeting request.
/// </summary>
/// <param name="Id"></param>
/// <param name="FirstName"></param>
/// <param name="Message"></param>
public record GreetDeveloperResponse(Guid? Id, string? FirstName, string Message)
{
    /// <summary>
    /// Constructs a response with only a message, used for anonymous greetings.
    /// </summary>
    /// <param name="message">The greeting message.</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
}