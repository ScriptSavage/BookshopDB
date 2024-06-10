using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookShopCodeFirst.Models;


[PrimaryKey (nameof(BookId),nameof(AwardId))]
public class BookAward
{
    public int Year { get; set; }

    public int BookId { get; set; }

    public int AwardId { get; set; }

    [ForeignKey(nameof(BookId))]
    public Book Type { get; set; } = null!;

    
    
    [ForeignKey(nameof(AwardId))]
    public Award Aw { get; set; } = null!;
    
    
    

}