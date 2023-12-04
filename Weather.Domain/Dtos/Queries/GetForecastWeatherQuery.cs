namespace Weather.Domain.Dtos.Queries
{
    public sealed class GetForecastWeatherQuery
    {
        public LocationDto Location { get; init; }
        public GetForecastWeatherQuery(double latitude, double longitude, string cityName)
        {
            Location = new LocationDto
            {
                Latitude = latitude,
                Longitude = longitude,
                CityName = cityName
            };
        }
    }
}
