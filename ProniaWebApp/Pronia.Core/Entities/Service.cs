namespace Pronia.Core.Entities;

public class Service:BaseEntity
{
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}
