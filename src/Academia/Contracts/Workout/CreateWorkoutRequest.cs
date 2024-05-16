namespace Academia.Contracts.Workout;

public record CreateWorkoutRequest(
    int? RoutineId,
    string? Name,
    List<CreateWorkoutItemRequest>? Items);
