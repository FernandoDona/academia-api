using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class Serie
{
    public int Id { get; private set; }
    public int WorkoutItemId { get; private set; }
    public decimal Weight { get; private set; }
    public int Reps { get; private set; }

    private Serie() { }
    private Serie(int id, decimal weight, int reps, int workoutItemId) 
    {
        Id = id;
        Weight = weight;
        Reps = reps;
        WorkoutItemId = workoutItemId;
    }

    public static Serie Create(decimal weight, int reps, int workoutItemId, int? id = null)
    {
        if (!ValidateWeight(weight))
            throw new ArgumentException("Peso inválido");
        if (!ValidateReps(reps))
            throw new ArgumentException("Repetições inválidas");
        return new Serie(id ?? 0, weight, reps, workoutItemId);
    }
    
    public static bool ValidateWeight(decimal weight) => weight >= 0;
    public static bool ValidateReps(int reps) => reps >= 0;
}
