using Microsoft.EntityFrameworkCore;

namespace EF;
public class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppContext())
        {
        }

        Console.ReadLine();
    }
}
