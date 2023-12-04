using FluentResults;
using Wheaterbit.Client.Dtos;

namespace Wheaterbit.Client
{
    internal class WeatherbitHttpClientBase
    {

        public async Task<Result<ForecastWeatherDto>> GetSixteenDayForecast(double latitude, double longitude, string cityName, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_options.Value.BaseUrl}/forecast/daily?lon={longitude}&lat={latitude}&city={cityName}"),
                Headers =
                {
                    { XRapidAPIHostHeader, _options.Value.XRapidAPIHost },
                    { XRapidAPIKeyHeader, _options.Value.XRapidAPIKey },
                }
            };

            return await SendAsyncSave<ForecastWeatherDto>(request, cancellationToken);
        }

        private Task<Result<T>> SendAsyncSave<T>(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}