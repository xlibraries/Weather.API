﻿using Validot;
using Weather.Domain.Dtos;

namespace Weather.Core.Validation
{
    internal static class GeneralPredicates
    {
        internal static readonly Predicate<double> isValidTemperature = m => m < 60 && m > -90;
        internal static readonly Predicate<double> isValidLatitude = m => m >= -90 && m <= 90;
        internal static readonly Predicate<double> isValidLongtitude = m => m >= -180 && m <= 180;
        internal static readonly Predicate<string> isValidCityName = m => m.Length > 0 && m.Length < 50;
        internal static readonly Specification<LocationDto> isValidLocation = s => s
                .Member(m => m.Latitude, m => m.Rule(isValidLatitude))
                .Member(m => m.Longitude, m => m.Rule(isValidLongtitude));
    }
}
