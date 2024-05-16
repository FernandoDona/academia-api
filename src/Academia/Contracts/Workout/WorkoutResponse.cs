namespace Academia.Contracts.Workout;
public record WorkoutResponse(
    int Id,
    int UserId,
    int? RoutineId,
    string Name,
    List<WorkoutItemResponse>? Items,
    List<WorkoutSessionResponse>? Sessions,
    DateTime CreatedAt);
