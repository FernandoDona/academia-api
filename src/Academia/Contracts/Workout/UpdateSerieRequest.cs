using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Contracts.Workout;

public record UpdateSerieRequest(
    Guid Id,
    int Repetitions,
    decimal Weight);