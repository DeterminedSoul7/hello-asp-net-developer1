using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.Rest.Assemblers;
/// <summary>
/// Assembler class to convert a GreetDeveloperRequest into a Developer entity.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a GreetDeveloperRequest into a Developer entity.
    /// </summary>
    /// <param name="request">The GreetDevelopment</param>
    /// <returns></returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request is null
            || string.IsNullOrWhiteSpace(request.FirstName)
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer(request.FirstName, request.LastName);
    }
}