using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class Routine
{
    private List<Workout>? _workouts;
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public IReadOnlyList<Workout>? Workouts => _workouts?.ToList();
    public DateTime CreatedAt { get; private set; }

    private Routine() { }

    private Routine(int id, int userId, string name, string? description, DateTime createdAt, List<Workout>? workouts = null)
    {
        Id = id;
        UserId = userId;
        Name = name;
        Description = description;
        CreatedAt = createdAt;
        _workouts = workouts;
    }

    public static Routine Create(string name, int userId, string? description = null, List<Workout>? workouts = null, int? id = null)
    {
        var routine = new Routine(id ?? 0, userId, name, description, DateTime.UtcNow, workouts);
        routine.Id = id ?? 0;
        routine.UserId = userId;
        routine.Name = name;
        routine.Description = description;
        routine.CreatedAt = DateTime.UtcNow;
        return routine;
    }

    public void AddWorkout(Workout workout)
    {
        _workouts ??= new();
        _workouts.Add(workout);
    }
}
