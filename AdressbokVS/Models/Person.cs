

using AdressbokVS.Interfaces;

namespace AdressbokVS.Models;

internal class Person : IPerson
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Adress { get; set; } = null!;
    
}

