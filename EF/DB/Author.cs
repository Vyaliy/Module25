namespace EF;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }

    //У одного автора может быть несколько книг
    //Навигационное свойство
    public List<Book> Books { get; set; } = new List<Book>();
}