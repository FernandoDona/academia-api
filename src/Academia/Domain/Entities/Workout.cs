namespace Academia.Domain.Entities;
public class Workout
{
    private List<WorkoutItem>? _items;
    private List<WorkoutSession>? _sessions;
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid? RoutineId { get; private set; }
    public string Name { get; private set; }
    public IReadOnlyList<WorkoutItem>? Items => _items?.ToList();
    public IReadOnlyList<WorkoutSession>? Sessions => _sessions?.ToList();
    public DateTime CreatedAt { get; private set; }

    private Workout() { }
    private Workout(Guid id, Guid userId, string name, DateTime createdAt, Guid? routineId = null, List<WorkoutItem>? items = null, List<WorkoutSession>? sessions = null)
    {
        Id = id;
        UserId = userId;
        Name = name;
        CreatedAt = createdAt;
        RoutineId = routineId;
        _items = items;
        _sessions = sessions;
    }

    public Workout Create(string name, Guid userId, DateTime createdAt, Guid? routineId = null, List<WorkoutItem>? items = null, List<WorkoutSession>? sessions = null, Guid? id = null)
    {
        return new Workout(id ?? Guid.NewGuid(), userId, name, createdAt, routineId, items, sessions);
    }

    public void StartNewSession(DateTime startedAt)
    {
        _sessions ??= new();

        FinishAnyOpenSession(startedAt);

        var newSession = WorkoutSession.Create(Id, startedAt);
        _sessions.Add(newSession);
    }

    public void FinishAnyOpenSession(DateTime finishedAt)
    {
        var activeSession = GetActiveSession();
        activeSession?.FinishSession(finishedAt);
    }

    private WorkoutSession? GetActiveSession()
    {
        var activeSession = Sessions?.FirstOrDefault(s => !s.IsFinished());
        return activeSession;
    }
}
