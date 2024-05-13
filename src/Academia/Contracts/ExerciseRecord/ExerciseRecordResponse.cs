using Academia.Contracts.Workout;

namespace Academia.Contracts.ExerciseRecord;

public record ExerciseRecordResponse(
    Guid ExerciseId,
    decimal WeightAverage,
    decimal RepetitionsAverage,
    decimal CreatedAt);