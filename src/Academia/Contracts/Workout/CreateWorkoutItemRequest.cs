using Academia.Contracts.Exercise;

namespace Academia.Contracts.Workout;

public record CreateWorkoutItemRequest(
    Guid ExerciseId,
    List<SerieRequest> Series);
