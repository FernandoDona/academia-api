namespace Academia.Contracts.Workout;

public record UpdateWorkoutRequest(
    int? RoutineId,
    string? Name,
    List<UpdateWorkoutItemRequest>? Items);
