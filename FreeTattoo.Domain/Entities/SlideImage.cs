namespace Domain.Entities;

public record SlideImage
{
    public Guid Id { get; init; }
    public string Image { get; init; } = string.Empty;
    public bool Deleted { get; init; } = false;
}