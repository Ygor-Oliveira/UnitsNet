//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Time is a dimension in which events can be ordered from the past through the present into the future, and also the measure of durations of events and the intervals between them.
    /// </summary>
    public struct  Duration
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DurationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public DurationUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Duration(double value, DurationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static DurationUnit BaseUnit { get; } = DurationUnit.Second;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Duration MaxValue { get; } = new Duration(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Duration MinValue { get; } = new Duration(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Duration Zero { get; } = new Duration(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Duration in Days.
        /// </summary>
        public double Days => As(DurationUnit.Day);

        /// <summary>
        ///     Get Duration in Hours.
        /// </summary>
        public double Hours => As(DurationUnit.Hour);

        /// <summary>
        ///     Get Duration in JulianYears.
        /// </summary>
        public double JulianYears => As(DurationUnit.JulianYear);

        /// <summary>
        ///     Get Duration in Microseconds.
        /// </summary>
        public double Microseconds => As(DurationUnit.Microsecond);

        /// <summary>
        ///     Get Duration in Milliseconds.
        /// </summary>
        public double Milliseconds => As(DurationUnit.Millisecond);

        /// <summary>
        ///     Get Duration in Minutes.
        /// </summary>
        public double Minutes => As(DurationUnit.Minute);

        /// <summary>
        ///     Get Duration in Months30.
        /// </summary>
        public double Months30 => As(DurationUnit.Month30);

        /// <summary>
        ///     Get Duration in Nanoseconds.
        /// </summary>
        public double Nanoseconds => As(DurationUnit.Nanosecond);

        /// <summary>
        ///     Get Duration in Seconds.
        /// </summary>
        public double Seconds => As(DurationUnit.Second);

        /// <summary>
        ///     Get Duration in Weeks.
        /// </summary>
        public double Weeks => As(DurationUnit.Week);

        /// <summary>
        ///     Get Duration in Years365.
        /// </summary>
        public double Years365 => As(DurationUnit.Year365);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Duration from Days.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromDays(double days) => new Duration(days, DurationUnit.Day);

        /// <summary>
        ///     Get Duration from Hours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromHours(double hours) => new Duration(hours, DurationUnit.Hour);

        /// <summary>
        ///     Get Duration from JulianYears.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromJulianYears(double julianyears) => new Duration(julianyears, DurationUnit.JulianYear);

        /// <summary>
        ///     Get Duration from Microseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMicroseconds(double microseconds) => new Duration(microseconds, DurationUnit.Microsecond);

        /// <summary>
        ///     Get Duration from Milliseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMilliseconds(double milliseconds) => new Duration(milliseconds, DurationUnit.Millisecond);

        /// <summary>
        ///     Get Duration from Minutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMinutes(double minutes) => new Duration(minutes, DurationUnit.Minute);

        /// <summary>
        ///     Get Duration from Months30.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMonths30(double months30) => new Duration(months30, DurationUnit.Month30);

        /// <summary>
        ///     Get Duration from Nanoseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromNanoseconds(double nanoseconds) => new Duration(nanoseconds, DurationUnit.Nanosecond);

        /// <summary>
        ///     Get Duration from Seconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromSeconds(double seconds) => new Duration(seconds, DurationUnit.Second);

        /// <summary>
        ///     Get Duration from Weeks.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromWeeks(double weeks) => new Duration(weeks, DurationUnit.Week);

        /// <summary>
        ///     Get Duration from Years365.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromYears365(double years365) => new Duration(years365, DurationUnit.Year365);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DurationUnit" /> to <see cref="Duration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Duration unit value.</returns>
        public static Duration From(double value, DurationUnit fromUnit)
        {
            return new Duration(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(DurationUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Duration ToUnit(DurationUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Duration(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case DurationUnit.Day: return _value*24*3600;
                case DurationUnit.Hour: return _value*3600;
                case DurationUnit.JulianYear: return _value*365.25*24*3600;
                case DurationUnit.Microsecond: return (_value) * 1e-6d;
                case DurationUnit.Millisecond: return (_value) * 1e-3d;
                case DurationUnit.Minute: return _value*60;
                case DurationUnit.Month30: return _value*30*24*3600;
                case DurationUnit.Nanosecond: return (_value) * 1e-9d;
                case DurationUnit.Second: return _value;
                case DurationUnit.Week: return _value*7*24*3600;
                case DurationUnit.Year365: return _value*365*24*3600;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(DurationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case DurationUnit.Day: return baseUnitValue/(24*3600);
                case DurationUnit.Hour: return baseUnitValue/3600;
                case DurationUnit.JulianYear: return baseUnitValue/(365.25*24*3600);
                case DurationUnit.Microsecond: return (baseUnitValue) / 1e-6d;
                case DurationUnit.Millisecond: return (baseUnitValue) / 1e-3d;
                case DurationUnit.Minute: return baseUnitValue/60;
                case DurationUnit.Month30: return baseUnitValue/(30*24*3600);
                case DurationUnit.Nanosecond: return (baseUnitValue) / 1e-9d;
                case DurationUnit.Second: return baseUnitValue;
                case DurationUnit.Week: return baseUnitValue/(7*24*3600);
                case DurationUnit.Year365: return baseUnitValue/(365*24*3600);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

