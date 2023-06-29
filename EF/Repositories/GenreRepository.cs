namespace EF;

public class GenreRepository
{
    public static Genre? Read(AppContext db, int id)
    {
        return db.Genres.FirstOrDefault(genre => genre.Id == id);
    }

    public static List<Genre> ReadAll(AppContext db)
    {
        return db.Genres.ToList();
    }

    public static void Insert(AppContext db, Genre genre)
    {
        db.Genres.Add(genre);
    }

    public static void Delete(AppContext db, Genre genre)
    {
        db.Genres.Remove(genre);

    }
}