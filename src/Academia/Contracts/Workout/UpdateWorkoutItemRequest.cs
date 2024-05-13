namespace Academia.Contracts.Workout;

public record UpdateWorkoutItemRequest(
    Guid Id,
    Guid ExerciseId,
    List<UpdateSerieRequest> Series);
