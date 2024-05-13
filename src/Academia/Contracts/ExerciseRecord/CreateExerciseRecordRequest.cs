using Academia.Contracts.Workout;

namespace Academia.Contracts.ExerciseRecord;

public record CreateExerciseRecordRequest(
    Guid ExerciseId,
    List<SerieRequest> Series);