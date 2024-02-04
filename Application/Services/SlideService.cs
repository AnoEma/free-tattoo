using Domain.Entities;
using Domain.InterfacesServices;
using Microsoft.Extensions.Logging;
using System.Collections;

namespace Application.Services;

public class SlideService : ISlideService
{
    private readonly ILogger<SlideService> _logger;

    public SlideService(ILogger<SlideService> logger)
    {
        _logger = logger;
    }

    public Task CreateSlide(SlideImage slideImage)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SlideImage>> GetSlide()
    {
        IEnumerable<SlideImage> slides = new List<SlideImage>();
        _logger.LogInformation("Started...");

        return Task.FromResult(slides);
    }
}