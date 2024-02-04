using Application.Services;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Application.Test;

public class SlideServiceTests
{
    [Fact]
    public void GetSlide_Should_Return_Sucess()
    {
        var loggerMock = Substitute.For<ILogger<SlideService>>();

        var service = new SlideService(loggerMock);

        var result = service.GetSlide();
    }

    private IEnumerable<SlideImage> GetSlideMock()
    {
        return new List<SlideImage>{
        new SlideImage
        {
            Id = Guid.NewGuid(),
            Image = Guid.NewGuid().ToString(),
            Deleted = true
        },
        new SlideImage
        {
            Id = Guid.NewGuid(),
            Image = Guid.NewGuid().ToString()
        }
       };
    }
}