

using AdressBook.Interfaces;
using AdressBook.Models;

public class Company : ICompany
{
    public string CompanyName { get ; set ; } = null!;
    public string OrganizationNumber { get ; set ; } = null!;
    public IPrivate ContactPerson { get; set; } = new Private();
    public Guid Id { get ; set ; } = new Guid();
    public string PhoneNumber { get ; set ; } = null!;
    public string Email { get ; set ; } = null!;
}
