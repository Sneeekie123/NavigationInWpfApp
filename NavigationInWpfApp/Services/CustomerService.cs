using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigationInWpfApp.Models;
using NavigationInWpfApp.ViewModels;
using System.Collections.ObjectModel;

namespace NavigationInWpfApp.Services;

public class CustomerService
{
    public List<Customer> _customerList = [];
    public readonly CustomerAddViewModel

    

    private Customer _customerForm = new();



  

    public void AddCustomerToList()
    {
        if (!string.IsNullOrWhiteSpace(CustomerForm.Firstname) && !string.IsNullOrWhiteSpace(CustomerForm.Lastname)
          && !string.IsNullOrWhiteSpace(CustomerForm.Phonenumber) && !string.IsNullOrWhiteSpace(CustomerForm.Email)
          && !string.IsNullOrWhiteSpace(CustomerForm.Homeadress))
        {
            CustomerList.Add(CustomerForm);
            CustomerForm = new();
        }
    }






    public IEnumerable<Customer> GetAll()
    {
        return _customerList;
    }








    public void RemoveCustomerFromList(Customer customer)
    {
        if (customer != null)
        {
            _customerList.Remove(customer);

        }

    }

}

 


