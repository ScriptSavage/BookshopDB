using System.ComponentModel.DataAnnotations;

namespace BookShopCodeFirst.Models;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public double Price { get; set; }
    
    [Required] 
    public int TotalPages { get; set; }


    public ICollection<Edition> Editios { get; set; } = new HashSet<Edition>();
    public ICollection<BookAward> BookAwards { get; set; } = new HashSet<BookAward>();
    public ICollection<BookAuthor> BookAuthors { get; set; } = new HashSet<BookAuthor>();





}