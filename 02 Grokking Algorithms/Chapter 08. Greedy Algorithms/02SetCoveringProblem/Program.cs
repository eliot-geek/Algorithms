namespace _02SetCoveringProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Another way to initialize
            //// Initialize the set of states needed
            //var statesNeeded = new HashSet<string> { "Montana", "Washington", "Oregon", "Idaho", "Nevada", "Utah", "California", "Arizona" };
            //// Initialize the dictionary of stations
            //var stations = new Dictionary<string, HashSet<string>>();
            //// Add stations to the dictionary
            //stations.Add("kone", new HashSet<string> { "Idaho", "Nevada", "Utah" });
            //stations.Add("ktwo", new HashSet<string> { "Washington", "Idaho", "Montana" });
            //stations.Add("kthree", new HashSet<string> { "Oregon", "Nevada", "California" });
            //stations.Add("kfour", new HashSet<string> { "Nevada", "Utah" });
            //stations.Add("kfive", new HashSet<string> { "California", "Arizona" });
            #endregion

            HashSet<string> statesNeeded = new HashSet<string>() { "Montana", "Washington", "Oregon", "Idaho", "Nevada", "Utah", "California", "Arizona" };
            Dictionary<string, HashSet<string>> stations = new Dictionary<string, HashSet<string>>();
            stations["kone"] = new HashSet<string>() { "Idaho", "Nevada", "Utah" };
            stations["ktwo"] = new HashSet<string>() { "Washington", "Idaho", "Montana" };
            stations["kthree"] = new HashSet<string>() { "Oregon", "Nevada", "California" };
            stations["kfour"] = new HashSet<string>() { "Nevada", "Utah" };
            stations["kfive"] = new HashSet<string>() { "California", "Arizona" };

            var finalStations = new HashSet<string>();

            // While there are still states needed
            while (statesNeeded.Any())
            {
                string? bestStation = null;
                var statesCovered = new HashSet<string>();

                // For each station
                foreach (var station in stations)
                {
                    var covered = new HashSet<string>(statesNeeded.Intersect(station.Value));
                    if (covered.Count > statesCovered.Count)
                    {
                        bestStation = station.Key;
                        statesCovered = covered;
                    }
                }
                statesNeeded.RemoveWhere(s => statesCovered.Contains(s));
                finalStations.Add(bestStation);

                // Break the loop if all states have been covered
                if (!statesNeeded.Any())
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(", ", finalStations));
        }
    }
}
