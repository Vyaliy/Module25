using Microsoft.Identity.Client;

namespace EF;

public static class UserRepository
{
    public static User? Read(AppContext db, int id)
    {
        return db.Users.FirstOrDefault(user => user.Id == id);
    }

    public static List<User> ReadAll(AppContext db)
    {
        return db.Users.ToList();
    }

    public static void Insert(AppContext db, User user) 
    {
        db.Users.Add(user);
    }

    public static void Delete(AppContext db, User user) 
    {
        db.Users.Remove(user);

    }

    public static void UpdateName(AppContext db, int id, string NewName) 
    {
        try
        {
            db.Users.FirstOrDefault(user => id == user.Id).Name = NewName;
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}