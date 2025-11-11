using Bunit;
using Xunit;
using EventEase.Models;
using Microsoft.Extensions.DependencyInjection;

namespace EventEase.Tests;

public class EventCardTests : TestContext
{
    public EventCardTests()
    {
        // register any services the components expect
        Services.AddSingleton<EventEase.Services.EventService>();
        Services.AddSingleton<EventEase.Services.AttendanceService>();
        Services.AddScoped<EventEase.Services.AppState>();
    }

    [Fact]
    public void EventCard_RendersAndBindsFields()
    {
        var evt = new EventModel { Id = 1, Name = "Test Event", Location = "Test Loc", Date = System.DateTime.Today };
        var cut = RenderComponent<EventEase.Components.EventCard>(parameters => parameters
            .Add(p => p.Event, evt)
            .Add(p => p.OnNavigateToDetails, new System.Action<int>((id) => { }))
        );

        // Ensure inputs render with initial values
        var inputs = cut.FindAll("input");
        Assert.True(inputs.Count >= 2);
        Assert.Contains("Test Event", cut.Markup);
    }

    [Fact]
    public void EventCard_DetailsButton_InvokesCallback()
    {
        var evt = new EventModel { Id = 2, Name = "Another Event", Location = "Loc", Date = System.DateTime.Today };
        int? received = null;
        var cut = RenderComponent<EventEase.Components.EventCard>(parameters => parameters
            .Add(p => p.Event, evt)
            .Add(p => p.OnNavigateToDetails, new System.Action<int>((id) => received = id))
        );

        cut.Find("button[type=button]").Click();
        Assert.Equal(2, received);
    }
}
