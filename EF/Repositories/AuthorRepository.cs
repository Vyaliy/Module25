namespace EF;

public static class AuthorRepository
{
    public static Author? Read(AppContext db, int id)
    {
        return db.Authors.FirstOrDefault(author => author.Id == id);
    }

    public static List<Author> ReadAll(AppContext db)
    {
        return db.Authors.ToList();
    }

    public static void Insert(AppContext db, Author author)
    {
        db.Authors.Add(author);
    }

    public static void Delete(AppContext db, Author author)
    {
        db.Authors.Remove(author);

    }
}