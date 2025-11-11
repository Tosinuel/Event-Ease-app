using Bunit;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using EventEase.Models;

namespace EventEase.Tests;

public class RegistrationTests : TestContext
{
    public RegistrationTests()
    {
        Services.AddSingleton<EventEase.Services.EventService>();
        Services.AddSingleton<EventEase.Services.AttendanceService>();
        Services.AddScoped<EventEase.Services.AppState>();
    }

    [Fact]
    public void Register_ShowsValidationMessages_WhenInvalid()
    {
        // render Register with no EventId
        var cut = RenderComponent<EventEase.Pages.Register>();

        // submit the form with empty fields
        var form = cut.Find("form");
        form.Submit();

        // validation summary should be present
        Assert.Contains("The Name field is required", cut.Markup);
    }
}
