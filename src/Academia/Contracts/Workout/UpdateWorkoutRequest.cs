namespace Academia.Contracts.Workout;

public record UpdateWorkoutRequest(
    Guid? RoutineId,
    string? Name,
    List<UpdateWorkoutItemRequest>? Items);
