namespace AdressBook.Interfaces;

public interface IPrivate : ICustomer
{
    string FirstName { get; set; }
    string LastName { get; set; }
}
