using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Contracts.Workout;

public record SerieResponse(
    Guid Id,
    int Repetitions,
    decimal Weight);