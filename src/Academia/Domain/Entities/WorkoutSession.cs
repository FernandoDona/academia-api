using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class WorkoutSession
{
    public Guid Id { get; private set; }
    public Guid WorkoutId { get; private set; }
    public DateTime StartedIn { get; private set; }
    public DateTime? DoneIn { get; private set; }

    private WorkoutSession() { }
    private WorkoutSession(Guid id, Guid workoutId, DateTime startedIn, DateTime? doneIn = null) 
    {
        Id = id;
        WorkoutId = workoutId;
        StartedIn = startedIn;
        DoneIn = doneIn;
    }

    public static WorkoutSession Create(Guid workoutId, DateTime startedIn, DateTime? doneIn = null, Guid? id = null)
    {
        if (!ValidateFinishDate(startedIn, doneIn))
            throw new ArgumentException($"A data de encerramento da sessão não pode ser menor que a data de início.");
        
        return new WorkoutSession(id ?? Guid.NewGuid(), workoutId, startedIn, doneIn);
    }


    public void FinishSession(DateTime finishedAt)
    {
        if (IsFinished())
            throw new InvalidOperationException("Não é possível finalizar uma sessão já iniciada");
        if (!ValidateFinishDate(StartedIn, finishedAt))
            throw new ArgumentException($"A data de encerramento da sessão não pode ser menor que a data de início.");

        DoneIn = finishedAt;
    }

    public bool IsFinished()
    {
        return DoneIn is not null;
    }

    public static bool ValidateFinishDate(DateTime startedIn, DateTime? doneIn)
    {
        return doneIn is null || doneIn > startedIn;
    }
}
