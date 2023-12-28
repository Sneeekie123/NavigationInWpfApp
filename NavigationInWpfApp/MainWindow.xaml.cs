using NavigationInWpfApp.ViewModels;
using System.Windows;


namespace NavigationInWpfApp;


public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;


    }

    private void ListViewItem_Selected(object sender, RoutedEventArgs e)
    {

    }

}