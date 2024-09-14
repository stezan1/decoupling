using System;
using Unity;
using DataAccessLayer; 

public class Program
{
    static void Main(string[] args)
    {
        // Create a Unity container
        var container = new UnityContainer();

        // Register the IRepository interface to the SqlServer implementation
        container.RegisterType<IRepository, SqlServer>();

        // Resolve the Customer class using Unity
        var customer = container.Resolve<Customer>();

        // Use the customer instance
        customer.Save();
    }
}
