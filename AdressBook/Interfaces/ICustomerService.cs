namespace AdressBook.Interfaces;

public interface ICustomerService
{
    bool AddCustomerToList(ICustomer customer);

    IEnumerable<ICustomer> GetCustomersFromList();
    ICustomer GetCustomerFromList(string email);
}
