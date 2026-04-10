namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity.
/// And trimer first and last name
/// </summary>
public class Developer
{
    /// <summary>
    /// Initializes a new instance of the Developer entity with trimmed names.
    /// </summary>
    /// <param name="firstName">The developer's first name.</param>
    /// <param name="lastName">The developer's last name.</param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? string.Empty : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? string.Empty : lastName.Trim();
    }
    
    /// <summary>
    /// Checks if the first or last name is empty after trimming
    /// </summary>

    public string GetFullName() => $"{FirstName} {LastName}";

    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);

    public Guid Id {get;} = Guid.NewGuid();

    public string FirstName { get; }

    public string LastName { get; }

}
