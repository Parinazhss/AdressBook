namespace AdressBook.Interfaces;

public interface ICompany : ICustomer
{
    string CompanyName { get; set; }
    string OrganizationNumber { get; set; } 
    IPrivate ContactPerson { get; set; }
}