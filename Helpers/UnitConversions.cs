namespace NateParker.Helpers
{
    public class UnitConversions
    {
        public double DistanceConversion (double distance, string inputUnit, string outputUnit)
        {
            double result = 0.0;

            switch (inputUnit)
            {
                // Meters
                case "m":
                    switch (outputUnit)
                    {
                        // Miles
                        case "M":
                            result = Math.Round(distance * 0.0006213712, 2, MidpointRounding.AwayFromZero);
                            break;
                    }
                    break;
            }

            return result;
        }

        public string FormattedTime (double time)
        {
            var timeSpan = TimeSpan.FromSeconds(time);

            return string.Format("{0:D2}d : {1:D2}h : {2:D2}m : {3:D2}s",
                timeSpan.Days,
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds);
        }
    }
}
