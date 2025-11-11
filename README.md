# Event-Ease (Blazor front-end)

This is a small Blazor WebAssembly front-end prototype for Event-Ease, an event management app.

Features included in this scaffold:
- Event list using virtualization for performance (large datasets)
- Event details page with graceful handling of invalid IDs
- EventCard component with two-way data binding and basic input validation
- Registration form with DataAnnotations validation
- Attendance tracker service (in-memory)
- Simple AppState for session-like behavior

How to run (requires .NET 8 SDK):

```powershell
cd "c:\Users\expre\Documents\C# Programming\Event-Ease-App"
dotnet restore
dotnet build
dotnet run --project EventEase.Client.csproj
```

Notes and next steps: add persistent storage, authentication, and deploy to GitHub Pages or a static host with an API backend.

Copilot assistance summary: Copilot helped generate component scaffolding, validation attributes, mock data generator, and suggested using Virtualize for performance.
