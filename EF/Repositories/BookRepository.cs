using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EF;

public static class BookRepository
{
    public static Book? Read(AppContext db, int id)
    {
        return db.Books.FirstOrDefault(book => book.Id == id);
    }

    public static List<Book> ReadAll(AppContext db)
    {
        return db.Books.ToList();
    }

    public static void Insert(AppContext db, Book book)
    {
        db.Books.Add(book);
    }

    public static void Delete(AppContext db, Book book)
    {
        db.Books.Remove(book);

    }

    public static void UpdateName(AppContext db, int id, DateTime NewReleaseDate)
    {
        try
        {
            db.Books.FirstOrDefault(book => id == book.Id).ReleaseDate = NewReleaseDate;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }

    //1 запрос
    public static List<Book> Select (AppContext db, string genreName, DateTime fromReleaseDate, DateTime toReleaseDate)
    {
        return db.Books
            .Where(book => book.Genre.Name == genreName)
            .Where(book => book.ReleaseDate >= fromReleaseDate)
            .Where(book => book.ReleaseDate <= toReleaseDate)
            .ToList();

    }

    //2 запрос
    public static int CountOfBooksOfAuthor (AppContext db, string authorName)
    {
        return db.Books.Count(book => book.Author.Name == authorName);
    }

    //3 запрос
    public static int CountOfBooksOfGenre (AppContext db, string genreName)
    {
        return db.Books.Count(book => book.Genre.Name == genreName);
    }
    
    //4 запрос. Честно не знаю как проверить иначе нормально
    public static bool IsExist (AppContext db, string authorName, string bookName)
    {
        if (db.Books.Count(book => book.Author.Name == authorName && book.Name == bookName) != 0)
            return true;
        return false;
    }

    //5 запрос. Не уверен, что default это null.
    public static bool IsInUse (AppContext db, int id)
    {
        return db.Books.FirstOrDefault(book => book.Id == id) != null;
    }

    //6 запрос
    public static int BooksOfUser (AppContext db, string userName)
    {
        return db.Books.Count(book => book.User.Name == userName);
    }

    //7 запрос
    public static Book LastReleasedBook (AppContext db)
    {
        return db.Books.MaxBy(book => book.ReleaseDate);
    }

    //8 запрос
    public static List<Book> GetListOfBooksAscNames (AppContext db)
    {
        return db.Books.OrderBy(book => book.Name).ToList();
    }

    //9 запрос
    public static List<Book> GetListOfBooksDescRelease (AppContext db)
    {
        return db.Books.OrderByDescending(book => book.ReleaseDate).ToList();
    }
}
