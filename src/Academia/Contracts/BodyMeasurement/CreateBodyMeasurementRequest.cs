using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Contracts.BodyMeasurement;

public record CreateBodyMeasurementRequest(
    Guid UserId,
    int Height,
    decimal Weight,
    int? Shoulders,
    int? Chest,
    int? Waist,
    int? Hip,
    int? RightArm,
    int? LeftArm,
    int? RightThigh,
    int? LeftThigh);