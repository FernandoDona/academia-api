namespace Academia.Contracts.Workout;

public record UpdateWorkoutItemRequest(
    int Id,
    int ExerciseId,
    List<UpdateSerieRequest> Series);
