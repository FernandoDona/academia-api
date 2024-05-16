using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class WorkoutItem
{
    private List<Serie>? _series;
    public int Id { get; private set; }
    public int WorkoutId { get; private set; }
    //public int ExerciseId { get; set; }
    public Exercise Exercise{ get; private set; }
    public IReadOnlyList<Serie>? Series => _series?.ToList();

    private WorkoutItem() { }

    private WorkoutItem(int id, int workoutId, Exercise exercise, List<Serie>? series = null)
    {
        Id = id;
        WorkoutId = workoutId;
        Exercise = exercise;
        _series = series;
    }

    public static WorkoutItem Create(int workoutId, Exercise exercise, List<Serie>? series = null, int? id = null)
    {
        return new WorkoutItem(id ?? 0, workoutId, exercise, series);
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
