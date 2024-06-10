using System.ComponentModel.DataAnnotations;

namespace BookShopCodeFirst.Models;

public class Edition
{
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int PuplicationYear { get; set; }


    private Book Book { get; set; } = null!;

}