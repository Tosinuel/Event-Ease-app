using EventEase.Models;
using System.Collections.Concurrent;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<EventModel> _events;

        public EventService()
        {
            _events = GenerateMockEvents(2000); // large dataset for performance testing
        }

        public Task<List<EventModel>> GetEventsAsync()
        {
            // return a shallow copy to simulate retrieval
            return Task.FromResult(_events.ToList());
        }

        public Task<EventModel?> GetEventByIdAsync(int id)
        {
            var e = _events.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(e);
        }

        private List<EventModel> GenerateMockEvents(int count)
        {
            var list = new List<EventModel>(count);
            for (int i = 1; i <= count; i++)
            {
                list.Add(new EventModel
                {
                    Id = i,
                    Name = $"Event {i}",
                    Date = DateTime.Now.AddDays(i % 365),
                    Location = $"Location {i % 50}",
                    Description = $"Description for event {i}."
                });
            }
            return list;
        }
    }
}
