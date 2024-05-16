using Academia.Contracts.Exercise;

namespace Academia.Contracts.Workout;

public record CreateWorkoutItemRequest(
    int ExerciseId,
    List<SerieRequest> Series);
