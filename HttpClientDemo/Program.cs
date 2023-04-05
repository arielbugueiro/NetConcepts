using Microsoft.Extensions.DependencyInjection;

namespace HttpClientDemo
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var urlPersonas = "https://localhost:7191/WeatherForecast";

            //No se debe utilizar
            //using (var httpClient = new HttpClient())
            //{
            //}

            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            var service = serviceCollection.BuildServiceProvider();
            var httpClientFactory = service.GetRequiredService<IHttpClientFactory>();

            //Example 1: Use Basic

            var httpClient = httpClientFactory.CreateClient();
            var responseMesagge = await httpClient.GetAsync(urlPersonas);
            //var responseMesagge = await httpClient.GetAsync("personas");
            responseMesagge.EnsureSuccessStatusCode();




            Console.WriteLine("Fin");
        }

        private static void Configure (this IServiceCollection service)
        {
            //Example 1 : Added HttpClientFactory Persona
            service.AddHttpClient("personas", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7214/api/personas");
                //client.DefaultRequestHeaders.Add("UserId", "25");  //Por defecto establecemos en la cabecera el valor 25.
            });

            //Example 2 : Added HttpClientFactory WeatherForecast
            service.AddHttpClient("weatherforecast", client =>
            {
                client.BaseAddress = new Uri("http://www.localhost:44301/weatherforecast");
            });
        }
    }

}