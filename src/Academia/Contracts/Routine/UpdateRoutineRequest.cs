using Academia.Contracts.Workout;

namespace Academia.Contracts.Routine;

public record UpdateRoutineRequest(
    string Name,
    string Description);