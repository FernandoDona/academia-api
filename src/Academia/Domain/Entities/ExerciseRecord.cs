using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class ExerciseRecord
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid ExerciseId { get; private set; }
    public decimal WeightAverage { get; private set; }
    public decimal RepetitionsAverage { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private ExerciseRecord() { }

    private ExerciseRecord(Guid id, Guid userId, Guid exerciseId, decimal weightAvarage, decimal repetitionsAverage, DateTime createdAt)
    {
        Id = id;
        UserId = userId;
        ExerciseId = exerciseId;
        WeightAverage = weightAvarage;
        RepetitionsAverage = repetitionsAverage;
        CreatedAt = createdAt;
    }

    public static ExerciseRecord Create(decimal weightAverage, decimal repetitionsAverage, Guid userId, Guid exerciseId, DateTime createdAt, Guid? id = null)
    {
        if (!ValidateWeight(weightAverage))
            throw new ArgumentException("Peso inválido");
        if (!ValidateRepetitions(repetitionsAverage))
            throw new ArgumentException("Repetições inválidas");

        return new ExerciseRecord(id ?? Guid.NewGuid(), userId, exerciseId, weightAverage, repetitionsAverage, createdAt);
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
