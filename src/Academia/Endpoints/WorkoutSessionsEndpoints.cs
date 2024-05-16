using Academia.Contracts.Workout;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Academia.Endpoints;

public static class WorkoutSessionsEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/workouts/sessions", GetAllWorkoutSessions)
        .WithName(nameof(GetAllWorkoutSessions))
        .WithOpenApi();

        app.MapGet("/workouts/{id}/sessions", GetWorkoutSessions)
        .WithName(nameof(GetWorkoutSessions))
        .WithOpenApi();

        app.MapPost("/workouts/{id}/sessions", StartWorkoutSession)
        .WithName(nameof(StartWorkoutSession))
        .WithOpenApi();

        app.MapPatch("/workouts/{id}/sessions", FinishWorkoutSession)
        .WithName(nameof(FinishWorkoutSession))
        .WithOpenApi();

        app.MapPatch("/workouts/{id}/sessions/item/{workoutItemId}", FinishWorkoutItemSession)
        .WithName(nameof(FinishWorkoutSession))
        .WithOpenApi();
    }

    private static async Task<Ok<List<WorkoutSessionResponse>>> GetAllWorkoutSessions(DateTime? startDate)
    {
        var sessions = new List<WorkoutSessionResponse>();
        return TypedResults.Ok(sessions);
    }

    private static async Task<Ok<List<WorkoutSessionResponse>>> GetWorkoutSessions(int id, DateTime? startdate)
    {
        var sessions = new List<WorkoutSessionResponse>();
        return TypedResults.Ok(sessions);
    }

    private static async Task<Created> StartWorkoutSession(int id)
    {
        return TypedResults.Created();
    }

    private static async Task<NoContent> FinishWorkoutSession(int id)
    {
        return TypedResults.NoContent();
    }

    private static async Task<NoContent> FinishWorkoutItemSession(int id, int workoutItemId)
    {
        return TypedResults.NoContent();
    }
}