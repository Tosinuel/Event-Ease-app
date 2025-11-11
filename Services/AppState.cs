using EventEase.Models;

namespace EventEase.Services
{
    // Simple in-memory session-like state for demonstration
    public class AppState
    {
        public RegistrationModel? CurrentUser { get; set; }
    }
}
