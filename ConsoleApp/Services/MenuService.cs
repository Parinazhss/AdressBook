

using AdressBook.Interfaces;
using AdressBook.Models;
using AdressBook.Services;

namespace ConsoleApp.Services
{
    internal class MenuService

    {
        private readonly ICustomerService _customerService = new CustomerService();
 
        public static void AddPrivateCustomerMenu()
        {
            IPrivate customer = new Private();

            Console.Write("Enter your First-Name:");
            customer.FirstName = Console.ReadLine()!;

            Console.Write("Enter your Last-Name:");
            customer.LastName = Console.ReadLine()!;


            _customerService.AddCustomerToList(customer);
            
        }

        public static  void AddCompanyCustomerMenu()
        {
            ICompany customer = new Company();

            Console.Write("Enter your Company-Name:");
            customer.CompanyName = Console.ReadLine()!;

            Console.Write("Enter your Company-Organization-Numeber:");
            customer.OrganizationNumber = Console.ReadLine()!;

            Console.Write("Enter your contact person First-Name:");
            customer.ContactPerson.FirstName= Console.ReadLine()!;

            Console.Write("Enter your contact person Last-Name:");
            customer.ContactPerson.LastName = Console.ReadLine()!;

            _customerService.AddCustomerToList(customer);
            

        }
        public static void ShowAllCustomersMenu()
        {
            var customers = _customerService.GetCustomersFromList();
            foreach (var customer in customers)
            {
                if (customer is IPrivate p)
                    Console.WriteLine($"{p.FirstName} {p.LastName}");

                if (customer is ICompany c)
                {
                    Console.WriteLine($"{c.CompanyName} orgnr. {c.OrganizationNumber}");
                    Console.WriteLine($"{c.ContactPerson.FirstName} {c.ContactPerson.LastName}");

                }

                Console.WriteLine();
                   

            }
        }

    }
}

