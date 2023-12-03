using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Define the ISearchable interface
public interface ISearchable<T>
{
    List<T> Search(Func<T, bool> predicate);
}

// Define the Product class
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}

// Define the User class
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<string> PurchaseHistory { get; set; } = new List<string>();
}

// Define the Order class
public class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public int Quantity { get; set; }
    public decimal TotalPrice => Products.Sum(p => p.Price * Quantity);
    public string Status { get; set; }
}

// Define the Store class implementing ISearchable
public class Store : ISearchable<Product>
{
    public List<Product> Products { get; set; } = new List<Product>();
    public List<User> Users { get; set; } = new List<User>();
    public List<Order> Orders { get; set; } = new List<Order>();

    // Implement the Search method from ISearchable
    public List<Product> Search(Func<Product, bool> predicate)
    {
        return Products.Where(predicate).ToList();
    }

    // Additional methods for managing users, products, and orders
}

class Program
{
    static void Main()
    {
        // Sample usage of the classes and interfaces
        Store myStore = new Store();

        // Adding sample products
        myStore.Products.Add(new Product { Name = "Product1", Price = 10.99m, Description = "Description1", Category = "Category1" });
        myStore.Products.Add(new Product { Name = "Product2", Price = 20.49m, Description = "Description2", Category = "Category2" });

        // Adding sample users
        myStore.Users.Add(new User { Username = "User1", Password = "Password1" });
        myStore.Users.Add(new User { Username = "User2", Password = "Password2" });

        // Adding a sample order
        Order order = new Order { Products = { myStore.Products[0] }, Quantity = 2, Status = "Pending" };
        myStore.Orders.Add(order);

        // Searching for products based on criteria
        List<Product> searchResults = myStore.Search(p => p.Price < 15 && p.Category == "Category1");

        // Displaying search results
        Console.WriteLine("Search Results:");
        foreach (var result in searchResults)
        {
            Console.WriteLine($"{result.Name} - {result.Price:C} - {result.Category}");
        }
        Console.ReadKey();
    }
}
