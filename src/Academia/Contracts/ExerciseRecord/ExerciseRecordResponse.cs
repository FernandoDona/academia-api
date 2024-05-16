using Academia.Contracts.Workout;

namespace Academia.Contracts.ExerciseRecord;

public record ExerciseRecordResponse(
    int ExerciseId,
    decimal WeightAverage,
    decimal RepetitionsAverage,
    decimal CreatedAt);