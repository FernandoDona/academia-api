namespace Academia.Contracts.Workout;

public record WorkoutItemResponse(
    int Id,
    int WorkoutId,
    int ExerciseId,
    bool AreSeriesEqual,
    List<SerieResponse> Series);
