using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, List<RegistrationModel>> _attendance = new();

        public void AddAttendance(int eventId, RegistrationModel registration)
        {
            if (!_attendance.ContainsKey(eventId)) _attendance[eventId] = new List<RegistrationModel>();
            _attendance[eventId].Add(registration);
        }

        public IReadOnlyDictionary<int, List<RegistrationModel>> GetAllAttendance()
        {
            return _attendance;
        }
    }
}
