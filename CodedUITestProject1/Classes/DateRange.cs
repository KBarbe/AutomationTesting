﻿using System;

/// <summary>
/// This class was setup based on Michael Fowler's Range by a colleague
/// </summary>
namespace AutomationTesting.Classes
{
    public class DateRange : IRange<DateTime>
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public bool Includes(DateTime value)
        {
            return (Start <= value) && (value <= End);
        }

        public bool Includes(IRange<DateTime> range)
        {
            return (Start <= range.Start) && (range.End <= End);
        }
    }
}
