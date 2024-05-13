namespace Academia.Contracts.Workout;

public record CreateWorkoutRequest(
    Guid? RoutineId,
    string? Name,
    List<CreateWorkoutItemRequest>? Items);
