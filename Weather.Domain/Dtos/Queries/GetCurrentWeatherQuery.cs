namespace Weather.Domain.Dtos.Queries
{
    public sealed class GetCurrentWeatherQuery
    {
        public LocationDto Location { get; init; }
        public GetCurrentWeatherQuery(double latitude, double longitude, string cityname)
        {
            Location = new LocationDto
            {
                Latitude = latitude,
                Longitude = longitude,
                CityName = cityname
            };
        }
    }
}
