﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Entities;
public class Exercise
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    private Exercise() { }

    private Exercise(int id, string name) 
    {
        Id = id;
        Name = name;
    }

    public static Exercise Create(string name, int? id = null)
    {
        if (!Exercise.ValidateName(name))
            throw new ArgumentException("O nome é obrigatório");

        return new Exercise(id ?? 0, name);
    }

    public static bool ValidateName(string name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }
}
