namespace Academia.Contracts.Workout;

public record WorkoutItemResponse(
    Guid Id,
    Guid WorkoutId,
    Guid ExerciseId,
    bool AreSeriesEqual,
    List<SerieResponse> Series);
