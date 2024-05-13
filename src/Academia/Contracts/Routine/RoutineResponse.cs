using Academia.Contracts.Workout;

namespace Academia.Contracts.Routine;

public record RoutineResponse(
    string Name,
    string Description,
    List<WorkoutResponse>? Workouts,
    DateTime createdAt);