namespace ServerManagement.Models
{
    public class CitiesRepository
    {
        private static List<string> cities =
        [
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
        ];

        public static List<string> GetCities() => cities;
    }
}
