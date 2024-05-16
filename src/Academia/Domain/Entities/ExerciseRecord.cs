using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class ExerciseRecord
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int ExerciseId { get; private set; }
    public decimal WeightAverage { get; private set; }
    public decimal RepetitionsAverage { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private ExerciseRecord() { }

    private ExerciseRecord(int id, int userId, int exerciseId, decimal weightAvarage, decimal repetitionsAverage, DateTime createdAt)
    {
        Id = id;
        UserId = userId;
        ExerciseId = exerciseId;
        WeightAverage = weightAvarage;
        RepetitionsAverage = repetitionsAverage;
        CreatedAt = createdAt;
    }

    public static ExerciseRecord Create(decimal weightAverage, decimal repetitionsAverage, int userId, int exerciseId, DateTime createdAt, int? id = null)
    {
        if (!ValidateWeight(weightAverage))
            throw new ArgumentException("Peso inválido");
        if (!ValidateRepetitions(repetitionsAverage))
            throw new ArgumentException("Repetições inválidas");

        return new ExerciseRecord(id ?? 0, userId, exerciseId, weightAverage, repetitionsAverage, createdAt);
    }

    public static bool ValidateWeight(decimal weight)
    {
        return weight > 0;
    }

    public static bool ValidateRepetitions(decimal repetitions)
    {
        return repetitions > 0;
    }
}
