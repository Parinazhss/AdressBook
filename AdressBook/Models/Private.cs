

using AdressBook.Interfaces;

namespace AdressBook.Models
{
    public class Private : IPrivate
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get ; set ; } = null!;
        public Guid Id { get ; set ; } = Guid.NewGuid();
        public string PhoneNumber { get ; set ; } = null!;
        public string Email { get ; set ; } = null!;
    }
}
