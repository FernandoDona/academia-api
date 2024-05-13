using Academia.Contracts.Workout;
using Academia.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Academia.Endpoints;

public static class WorkoutsEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/workouts", GetWorkouts)
        .WithName(nameof(GetWorkout))
        .WithOpenApi();

        app.MapGet("/workouts/{id}", GetWorkout)
        .WithName(nameof(GetWorkout))
        .WithOpenApi();

        app.MapPost("/workouts", CreateWorkout)
        .WithName(nameof(CreateWorkout))
        .WithOpenApi();

        app.MapPost("/workouts{id}/item", CreateWorkoutItem)
        .WithName(nameof(CreateWorkoutItem))
        .WithOpenApi();

        app.MapPut("/workouts/{id}", UpdateWorkout)
        .WithName(nameof(UpdateWorkout))
        .WithOpenApi();

        app.MapDelete("/workouts/{id}", DeleteWorkout)
        .WithName(nameof(DeleteWorkout))
        .WithOpenApi();
    }

    private static async Task<Ok<List<WorkoutResponse>>> GetWorkouts(DateTime? startTime)
    {
        var workouts = new List<WorkoutResponse>();
        return TypedResults.Ok(workouts);
    }

    private static async Task<Ok<WorkoutResponse>> GetWorkout(Guid id)
    {
        var workout = new WorkoutResponse(Guid.Empty, Guid.Empty, Guid.Empty, string.Empty, null, null, DateTime.Now);
        return TypedResults.Ok(workout);
    }

    private static async Task<CreatedAtRoute<WorkoutResponse>> CreateWorkout(CreateWorkoutRequest workout)
    {
        var newWorkout = new WorkoutResponse(Guid.Empty, Guid.Empty, Guid.Empty, string.Empty, null, null, DateTime.Now);
        return TypedResults.CreatedAtRoute(newWorkout, nameof(CreateWorkout), new { id = newWorkout.Id });
    }

    private static async Task<Created> CreateWorkoutItem(Guid id, CreateWorkoutItemRequest workout)
    {
        return TypedResults.Created();
    }

    private static async Task<NoContent> UpdateWorkout(Guid id, UpdateWorkoutRequest workout)
    {
        return TypedResults.NoContent();
    }

    private static async Task<NoContent> DeleteWorkout(Guid id)
    {
        return TypedResults.NoContent();
    }
}


