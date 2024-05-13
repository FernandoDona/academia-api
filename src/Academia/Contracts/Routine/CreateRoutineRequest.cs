using Academia.Contracts.Workout;

namespace Academia.Contracts.Routine;

public record CreateRoutineRequest(
    string Name,
    string Description);