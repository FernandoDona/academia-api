using Academia.Contracts.BodyMeasurement;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Academia.Endpoints;

public static class MeasurementRecordsEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/measurement-records", GetBodyMeasurementRecords)
        .WithName(nameof(GetBodyMeasurementRecords))
        .WithOpenApi();

        app.MapPost("/measurement-records", CreateBodyMeasurementRecord)
        .WithName(nameof(CreateBodyMeasurementRecord))
        .WithOpenApi();

        app.MapDelete("/measurement-records", DeleteBodyMeasurementRecord)
        .WithName(nameof(DeleteBodyMeasurementRecord))
        .WithOpenApi();
    }

    private static async Task<Ok<List<BodyMeasurementResponse>>> GetBodyMeasurementRecords()
    {
        var measurements = new List<BodyMeasurementResponse>();
        return TypedResults.Ok(measurements);
    }

    private static async Task<Created> CreateBodyMeasurementRecord(CreateBodyMeasurementRequest measurement)
    {
        return TypedResults.Created();
    }

    private static async Task<NoContent> DeleteBodyMeasurementRecord(int id)
    {
        return TypedResults.NoContent();
    }
}
