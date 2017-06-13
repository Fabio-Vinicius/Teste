using System;

namespace Grade
{
    public class ThrowAawayGradeBook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;

            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}