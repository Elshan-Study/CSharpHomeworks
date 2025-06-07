using System.Text.Json;
using Models;
using Utils;

namespace Services;

public static class DataService
{
    public static void SaveUserData(User user)
    {
        string path = $"data/{user.Username}/orders.json";
        var json = JsonSerializer.Serialize(user.Orders, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
        Logger.Log($"{user.Username} saved data.");
    }

    public static void LoadUserData(User user)
    {
        string path = $"data/{user.Username}/orders.json";
        if (!File.Exists(path)) return;

        try
        {
            var json = File.ReadAllText(path);
            user.Orders = JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
            Logger.Log($"{user.Username} loaded data.");
        }
        catch
        {
            Console.WriteLine("Error loading data.");
        }
    }
}