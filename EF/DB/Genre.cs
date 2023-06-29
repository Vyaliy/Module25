namespace EF;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }

    //Один и тот же жанр может быть у многих книг
    //Навигационное свойство
    public List<Book> Books { get; set; } = new List<Book>();

}