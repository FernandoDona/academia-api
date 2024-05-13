using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class BodyMeasurement
{
    public Guid Id { get; set; }
    public Guid UserId { get; private set; }
    public int Height { get; private set; }
    public decimal Weight { get; private set; }
    public int? Shoulders { get; private set; }
    public int? Chest { get; private set; }
    public int? Waist { get; private set; }
    public int? Hip { get; private set; }
    public int? RightArm { get; private set; }
    public int? LeftArm { get; private set; }
    public int? RightThigh { get; private set; }
    public int? LeftThigh { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private BodyMeasurement() { }

    private BodyMeasurement(Guid id, Guid userId, DateTime createdAt, int height, decimal weight, int? shoulders = null, int? chest = null, int? waist = null, int? hip = null, int? rightArm = null, int? leftArm = null, int? rightThigh = null, int? leftThigh = null) 
    {
        Id = id;
        UserId = userId;
        Height = height;
        Weight = weight;
        Shoulders = shoulders;
        Chest = chest;
        Waist = waist;
        Hip = hip;
        RightArm = rightArm;
        LeftArm = leftArm;
        RightThigh = rightThigh;
        LeftThigh = leftThigh;
        CreatedAt = createdAt;
    }

    public BodyMeasurement Create(int height, decimal weight, Guid userId, DateTime createdAt, Guid? id = null)
    {
        var bodyMeasurement = new BodyMeasurement();

        bodyMeasurement.Id = id is null ? Guid.NewGuid() : id.Value;
        bodyMeasurement.UserId = userId;
        bodyMeasurement.SetHeight(height);
        bodyMeasurement.SetWeight(weight);
        bodyMeasurement.CreatedAt = createdAt;

        return bodyMeasurement;
    }

    public void SetHeight(int measure)
    {
        if (ValidateMeasure(measure))
            Height = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetWeight(decimal measure)
    {
        if (ValidateMeasure(measure))
            Weight = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetShoulders(int measure)
    {
        if (ValidateMeasure(measure))
            Shoulders = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetChest(int measure)
    {
        if (ValidateMeasure(measure))
            Chest = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetWaist(int measure)
    {
        if (ValidateMeasure(measure))
            Waist = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetHip(int measure)
    {
        if (ValidateMeasure(measure))
            Hip = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetRightArm(int measure)
    {
        if (ValidateMeasure(measure))
            RightArm = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetLeftArm(int measure)
    {
        if (ValidateMeasure(measure))
            LeftArm = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetRightThigh(int measure)
    {
        if (ValidateMeasure(measure))
            RightThigh = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }
    public void SetLeftThigh(int measure)
    {
        if (ValidateMeasure(measure))
            LeftThigh = measure;
        else
            throw new ArgumentException($"{measure} não é uma medida válida.");
    }

    private bool ValidateMeasure(int measure) => measure >= 0;
    private bool ValidateMeasure(decimal measure) => measure >= 0;
}
