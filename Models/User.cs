namespace Models;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; } 
    public List<Order> Orders { get; set; } = new List<Order>();
}