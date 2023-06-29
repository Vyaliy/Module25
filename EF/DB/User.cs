namespace EF;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }

    //У одного человека может быть несколько книг
    //Навигационное свойство
    public List<Book> Books { get; set; } = new List<Book>();
}
