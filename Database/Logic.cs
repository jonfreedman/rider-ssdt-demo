using System;

namespace Database
{
    public class Logic
    {
        public static double? Abs(double? value)
        {
            if (value.HasValue) return Math.Abs(value.Value);
            return null;
        }
    }
}
