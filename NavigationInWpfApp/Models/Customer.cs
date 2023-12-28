namespace NavigationInWpfApp.Models;

public class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Phonenumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Homeadress { get; set; } = null!;
}
