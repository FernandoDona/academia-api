namespace Academia.Contracts.Workout;

public record WorkoutSessionResponse(
    int Id,
    int WorkoutId,
    DateTime StartedAt,
    DateTime? FinishedAt);
