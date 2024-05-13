using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Contracts.Workout;

public record SerieRequest(
    int Repetitions,
    decimal Weight);