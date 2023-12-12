namespace AdressBook.Interfaces;

public interface ICustomer
{
    Guid Id { get; set; }       
  
    string PhoneNumber { get; set; }
    string Email { get; set; }


}
