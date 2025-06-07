using Models;
using Utils;

namespace Services;
using System.Text.Json;

public class AuthService
{
    private const string UsersFile = "data/users.json";
    private static List<User> users = new();

    static AuthService()
    {
        if (File.Exists(UsersFile))
        {
            try
            {
                var json = File.ReadAllText(UsersFile);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            catch
            {
                users = new List<User>();
            }
        }
    }

    public static User? Login(string username, string password)
    {
        string hashedPassword = PasswordHasher.Hash(password);
        return users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);
    }

    public static bool Register(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return false;
        if (users.Any(u => u.Username == username)) return false;

        string hashedPassword = PasswordHasher.Hash(password);
        users.Add(new User { Username = username, Password = hashedPassword });
        SaveUsers();
        Directory.CreateDirectory($"data/{username}");
        return true;
    }

    private static void SaveUsers()
    {
        var dir = Path.GetDirectoryName(UsersFile);
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir!);

        var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(UsersFile, json);
    }

}