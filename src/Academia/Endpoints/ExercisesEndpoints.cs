using Academia.Contracts.Exercise;
using Academia.Contracts.ExerciseRecord;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Academia.Endpoints;

public static class ExercisesEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/exercises", GetExercises)
        .WithName(nameof(GetExercise))
        .WithOpenApi();

        app.MapGet("/exercises/{id}", GetExercise)
        .WithName(nameof(GetExercise))
        .WithOpenApi();

        app.MapGet("/exercises/{id}/records", GetExerciseRecords)
        .WithName(nameof(GetExerciseRecords))
        .WithOpenApi();

        app.MapPost("/exercises", CreateExercise)
        .WithName(nameof(CreateExercise))
        .WithOpenApi();

        app.MapPut("/exercises/{id}", UpdateExercise)
        .WithName(nameof(UpdateExercise))
        .WithOpenApi();

        app.MapDelete("/exercises/{id}", DeleteExercise)
        .WithName(nameof(DeleteExercise))
        .WithOpenApi();
    }

    private static async Task<Ok<List<ExerciseResponse>>> GetExercises()
    {
        var exercises = new List<ExerciseResponse>();
        return TypedResults.Ok(exercises);
    }

    private static async Task<Ok<ExerciseResponse>> GetExercise(Guid id)
    {
        var exercise = new ExerciseResponse(id, string.Empty);
        return TypedResults.Ok(exercise);
    }

    private static async Task<Ok<List<ExerciseRecordResponse>>> GetExerciseRecords(Guid id)
    {
        var records = new List<ExerciseRecordResponse>();
        return TypedResults.Ok(records);
    }

    private static async Task<CreatedAtRoute<ExerciseResponse>> CreateExercise(CreateExerciseRequest exercise)
    {
        var newExercise = new ExerciseResponse(Guid.Empty, exercise.Name);
        return TypedResults.CreatedAtRoute(newExercise, nameof(CreateExercise), new { id = newExercise.Id });
    }

    private static async Task<NoContent> UpdateExercise(Guid id, UpdateExerciseRequest exercise)
    {
        return TypedResults.NoContent();
    }

    private static async Task<NoContent> DeleteExercise(Guid id)
    {
        return TypedResults.NoContent();
    }
}
