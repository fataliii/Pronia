using System.ComponentModel.DataAnnotations;

namespace Pronia.Business.ViewModels.SliderViewModels;

public class SliderPostVM
{
    [Required(ErrorMessage ="Doldur"),MaxLength(30),MinLength(10)]
    public string Title { get; set; } = null!;
   
    [Required,MaxLength(100)]
    public string Description { get; set; } = null!;
    public int Discount { get; set; }
    [Required]
    public string ImageUrl { get; set; } = null!;
   
}
 