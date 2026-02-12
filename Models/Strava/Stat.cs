namespace NateParker.Models.Strava
{
    using Newtonsoft.Json;

    public class Stat
    {
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        [JsonProperty("recent_ride_totals")]
        public RecentRideTotals? RecentRideTotal { get; set; }

        [JsonProperty("all_ride_totals")]
        public AllRideTotals? AllRideTotal { get; set; }

        [JsonProperty("recent_run_totals")]
        public RecentRunTotals? RecentRunTotal { get; set; }

        [JsonProperty("all_run_totals")]
        public AllRunTotals? AllRunTotal { get; set; }

        [JsonProperty("recent_swim_totals")]
        public RecentSwimTotals? RecentSwimTotal { get; set; }

        [JsonProperty("all_swim_totals")]
        public AllSwimTotals? AllSwimTotal { get; set; }

        [JsonProperty("ytd_ride_totals")]
        public YtdRideTotals? YtdRideTotal { get; set; }

        [JsonProperty("ytd_run_totals")]
        public YtdRunTotals? YtdRunTotal { get; set; }

        [JsonProperty("ytd_swim_totals")]
        public YtdSwimTotals? YtdSwimTotal { get; set; }
        

        public class AllRideTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }

        public class AllRunTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }

        public class AllSwimTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }

        public class RecentRideTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }

            [JsonProperty("achievement_count")]
            public int AchievementCount { get; set; }
        }

        public class RecentRunTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }

            [JsonProperty("achievement_count")]
            public int AchievementCount { get; set; }
        }

        public class RecentSwimTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public double Distance { get; set; }

            [JsonProperty("moving_time")]
            public int MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public int ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }

            [JsonProperty("achievement_count")]
            public int AchievementCount { get; set; }
        }

        public class YtdRideTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public int Distance { get; set; }

            [JsonProperty("moving_time")]
            public double MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public double elapsed_time { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }

        public class YtdRunTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public int Distance { get; set; }

            [JsonProperty("moving_time")]
            public double MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public double ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }

        public class YtdSwimTotals
        {
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("distance")]
            public int Distance { get; set; }

            [JsonProperty("moving_time")]
            public double MovingTime { get; set; }

            [JsonProperty("elapsed_time")]
            public double ElapsedTime { get; set; }

            [JsonProperty("elevation_gain")]
            public double ElevationGain { get; set; }
        }
    }
}
