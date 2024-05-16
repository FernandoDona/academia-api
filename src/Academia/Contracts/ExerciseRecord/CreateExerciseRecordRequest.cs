using Academia.Contracts.Workout;

namespace Academia.Contracts.ExerciseRecord;

public record CreateExerciseRecordRequest(
    int ExerciseId,
    List<SerieRequest> Series);