using Domain.Entities;

namespace Domain.InterfacesServices;

public interface ISlideService
{
    Task<IEnumerable<SlideImage>> GetSlide();
    Task CreateSlide(SlideImage slideImage);
}