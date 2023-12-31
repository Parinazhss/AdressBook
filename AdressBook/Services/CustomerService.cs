﻿
using AdressBook.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AdressBook.Services;

public class CustomerService : ICustomerService
{
    private readonly FileService _fileService = new FileService();
    private List<ICustomer> _customers = [];
    private readonly string _filePath = @"c:\projects\contacts.json";



    public bool AddCustomerToList(ICustomer customer)
    {
        try
        {
            if (! _customers.Any(x => x.Email == customer.Email))
            {
                _customers.Add(customer);

                string json = JsonConvert.SerializeObject(customer , new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All});

                var result = _fileService.SaveContectToFile(_filePath, json);
                return result;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public ICustomer GetCustomerFromList(string email)
    {
        try
        {
            GetCustomersFromList();

            var customer = _customers.FirstOrDefault(x => x.Email == email);
            return customer ??= null!;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public IEnumerable<ICustomer> GetCustomersFromList()
    {
        try
            {
            var content = _fileService.GetContentFromFile(_filePath);
            if (! string.IsNullOrEmpty(content))
            {
                _customers = JsonConvert.DeserializeObject<List<ICustomer>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })!;
                return _customers;
            }
        }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}
