
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using NavigationInWpfApp.Models;
using NavigationInWpfApp.Services;
using System.Collections.ObjectModel;

namespace NavigationInWpfApp.ViewModels;

public partial class CustomerViewModel : ObservableObject
{
    private readonly IServiceProvider _sp;
    private readonly CustomerService _customerService;

    [ObservableProperty]

    private Customer _customerForm = new();

    [ObservableProperty]
    private ObservableCollection<Customer> _customerList = [];



    public CustomerViewModel(IServiceProvider sp, CustomerService customerService)
    {
        _sp = sp;
        _customerService = customerService;

        _customerList = new ObservableCollection<Customer>(_customerService.GetAll());
    }

    [RelayCommand]

    private void NavigateToList()
    {
        

        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<CustomerAddViewModel>();

       
    }

}
