namespace Models;

public class Order
{
    public string Title { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public List<Service> Services { get; set; } = new List<Service>();
    
    public decimal Total => Services.Sum(s => s.Price);
}
