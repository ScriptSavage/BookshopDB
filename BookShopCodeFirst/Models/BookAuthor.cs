using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookShopCodeFirst.Models;



[PrimaryKey(nameof(BookId),nameof(AuthorId))]
public class BookAuthor
{

    public int BookId { get; set; }

    public int  AuthorId { get; set; }
    
    
    [ForeignKey(nameof(BookId))]
    public Book Book { get; set; }

    [ForeignKey(nameof(AuthorId))]
    public Author Author { get; set; }
    
    
}