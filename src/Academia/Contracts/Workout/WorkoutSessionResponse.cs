namespace Academia.Contracts.Workout;

public record WorkoutSessionResponse(
    Guid Id,
    Guid WorkoutId,
    DateTime StartedAt,
    DateTime? FinishedAt);
