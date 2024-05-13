using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class WorkoutItem
{
    private List<Serie>? _series;
    public Guid Id { get; private set; }
    public Guid WorkoutId { get; private set; }
    //public Guid ExerciseId { get; set; }
    public Exercise Exercise{ get; private set; }
    public IReadOnlyList<Serie>? Series => _series?.ToList();

    private WorkoutItem() { }

    private WorkoutItem(Guid id, Guid workoutId, Exercise exercise, List<Serie>? series = null)
    {
        Id = id;
        WorkoutId = workoutId;
        Exercise = exercise;
        _series = series;
    }

    public static WorkoutItem Create(Guid workoutId, Exercise exercise, List<Serie>? series = null, Guid? id = null)
    {
        return new WorkoutItem(id ?? Guid.NewGuid(), workoutId, exercise, series);
    }

    public void AddSerie(Serie serie)
    {
        _series ??= new();
        _series.Add(serie);
    }

    public void RemoveSerie(Serie serie)
    {
        _series?.Remove(serie);
    }
}
