
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



public class Miniature
{
    [Key]
    public int Id{get; set; }

    [Required]
    public string Name{get; set;}
    [DisplayName("Table ready!")]
    public bool TableReady{get; set;} = false;

    public string? Description{ get; set;}
}