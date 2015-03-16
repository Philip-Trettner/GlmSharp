using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharp
{
    internal static class Extensions
    {
        public static double LengthSqr(this Complex c)
        {
            return c.Real * c.Real + c.Imaginary * c.Imaginary;
        }

        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.
        // see http://stackoverflow.com/questions/4124189/performing-math-operations-on-decimal-datatype-in-c
        public static decimal Sqrt(this decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }

        public static int Clamp(this int v, int min = 0, int max = 1) => v < min ? min : v > max ? max : min;
        public static uint Clamp(this uint v, uint min = 0, uint max = 1) => v < min ? min : v > max ? max : min;
        public static float Clamp(this float v, float min = 0, float max = 1) => v < min ? min : v > max ? max : min;
        public static double Clamp(this double v, double min = 0, double max = 1) => v < min ? min : v > max ? max : min;
        public static decimal Clamp(this decimal v, decimal min = 0, decimal max = 1) => v < min ? min : v > max ? max : min;
        public static long Clamp(this long v, long min = 0, long max = 1) => v < min ? min : v > max ? max : min;

        public static int HermiteInterpolationOrder3(this int v) => v * v * (3 - 2 * v);
        public static uint HermiteInterpolationOrder3(this uint v) => v * v * (3 - 2 * v);
        public static float HermiteInterpolationOrder3(this float v) => v * v * (3 - 2 * v);
        public static double HermiteInterpolationOrder3(this double v) => v * v * (3 - 2 * v);
        public static decimal HermiteInterpolationOrder3(this decimal v) => v * v * (3 - 2 * v);
        public static long HermiteInterpolationOrder3(this long v) => v * v * (3 - 2 * v);

        public static int HermiteInterpolationOrder5(this int v) => v * v * v * (6 * v * v - 15 * v + 10);
        public static uint HermiteInterpolationOrder5(this uint v) => v * v * v * (6 * v * v - 15 * v + 10);
        public static float HermiteInterpolationOrder5(this float v) => v * v * v * (6 * v * v - 15 * v + 10);
        public static double HermiteInterpolationOrder5(this double v) => v * v * v * (6 * v * v - 15 * v + 10);
        public static decimal HermiteInterpolationOrder5(this decimal v) => v * v * v * (6 * v * v - 15 * v + 10);
        public static long HermiteInterpolationOrder5(this long v) => v * v * v * (6 * v * v - 15 * v + 10);
    }
}
