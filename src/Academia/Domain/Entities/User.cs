using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class User
{
    public int Id { get; private set; }
    public List<BodyMeasurement>? BodyMeasurements { get; private set; }
    public List<ExerciseRecord>? ExerciseRecords { get; private set; }

    private User() { }
    private User(int id, List<BodyMeasurement>? bodyMeasurements, List<ExerciseRecord>? exerciseRecords)
    {
        Id = id;
        BodyMeasurements = bodyMeasurements;
        ExerciseRecords = exerciseRecords;
    }

    public static User Create(int? id = null, List<BodyMeasurement>? bodyMeasurements = null, List<ExerciseRecord>? exerciseRecords = null)
    {
        return new User(id ?? 0, bodyMeasurements, exerciseRecords);
    }
}
