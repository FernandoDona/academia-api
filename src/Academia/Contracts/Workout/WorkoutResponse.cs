namespace Academia.Contracts.Workout;
public record WorkoutResponse(
    Guid Id,
    Guid UserId,
    Guid? RoutineId,
    string Name,
    List<WorkoutItemResponse>? Items,
    List<WorkoutSessionResponse>? Sessions,
    DateTime CreatedAt);
