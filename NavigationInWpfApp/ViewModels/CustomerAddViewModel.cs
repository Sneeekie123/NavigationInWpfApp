using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using NavigationInWpfApp.Models;
using NavigationInWpfApp.Services;
using System.Collections.ObjectModel;


namespace NavigationInWpfApp.ViewModels;

public partial class CustomerAddViewModel : ObservableObject
{

    private readonly IServiceProvider _sp;
    private readonly CustomerService _customerService;

    [ObservableProperty]

    public Customer _customerForm = new();

    [ObservableProperty]
    public ObservableCollection<Customer> _customerList = [];

    public CustomerAddViewModel(IServiceProvider sp, CustomerService customerService)
    {
        _sp = sp;
        _customerService = customerService;


        _customerList = new ObservableCollection<Customer>(_customerService.GetAll());
    }

    [RelayCommand]
    private void NavigateToCustomerView()
    {
       

        var mainViewMode = _sp.GetRequiredService<MainViewModel>();
        mainViewMode.CurrentViewModel = _sp.GetRequiredService<CustomerViewModel>();


    }










    [RelayCommand]

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


    [RelayCommand]
    public void RemoveCustomerFromList(Customer customer)
    {
        if (customer != null)
        {
            CustomerList.Remove(customer);
            
        }

    }





}
