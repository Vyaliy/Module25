namespace EF;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    //У книги один жанр (допутсим)
    //Внешний ключ
    public int GenreId { get; set; }
    //Навигационное свойство
    public Genre Genre { get; set; }

    //Одна книга может быть только у одного человека
    //Внешний ключ
    public int UserId { get; set; }
    //Навигационное свойство
    public User User { get; set; }

    //Допустим у книги только один автор
    //Внешний ключ
    public int AuthorId { get; set; }
    //Навигационное свойство
    public Author Author { get; set; }

}
