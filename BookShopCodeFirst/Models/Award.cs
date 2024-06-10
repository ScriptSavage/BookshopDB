using System.ComponentModel.DataAnnotations;

namespace BookShopCodeFirst.Models;

public class Award
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    
}