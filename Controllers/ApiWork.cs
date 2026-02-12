namespace NateParker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NateParker.Helpers;
    using NateParker.Models;
    using NateParker.Models.Strava;
    using NateParker.ViewModels;
    using Newtonsoft.Json;

    public class ApiWork : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CatFacts()
        {
            var catFact = new CatFact();
            var viewModel = new CatFactViewModel();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://catfact.ninja/fact?max_length=140");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    catFact = JsonConvert.DeserializeObject<CatFact>(content);
                }
            }

            if (catFact != null)
            {
                viewModel.Fact = catFact.Fact;
                viewModel.Length = catFact.Length;
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Strava()
        {
            var athlete = new Athlete();
            var viewModel = new StravaViewModel();
            var conversion = new UnitConversions();
            string refreshToken = "";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://www.strava.com/oauth/authorize?client_id=170940&response_type=code&redirect_uri=http://localhost:5081/ApiWork/Strava");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                }
            }




            // To make requests, need to check if access toek is expired or not, if it is, use refresh token to authenticate
            using (var cl = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", ""),
                    new KeyValuePair<string, string>("client_secret", ""),
                    //new KeyValuePair<string, string>("code", "ReplaceWithCode"),
                    new KeyValuePair<string, string>("grant_type", "password"),

                   new KeyValuePair<string, string>("username", "parkerjn3@gmail.com"),
                new KeyValuePair<string, string>("password", "T")
            });
                var response = await cl.PostAsync("https://www.strava.com/oauth/token", content);
            }





            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "");
                var response = await client.GetAsync("https://www.strava.com/api/v3/athlete");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    athlete = JsonConvert.DeserializeObject<Athlete>(content);
                }
            }

            if (athlete != null)
            {
                var stat = new Stat();

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "");
                    var response = await client.GetAsync("https://www.strava.com/api/v3//athletes/" + athlete.ID + "/stats");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        stat = JsonConvert.DeserializeObject<Stat>(content);
                    }
                }

                if (stat != null)
                {
                    viewModel.TotalRides = (stat.AllRideTotal != null ? stat.AllRideTotal.Count : 0);
                    viewModel.TotalDistance = (stat.AllRideTotal != null ? conversion.DistanceConversion(stat.AllRideTotal.Distance, "m", "M") : 0);
                    viewModel.TotalMovingTime = (stat.AllRideTotal != null ? conversion.FormattedTime(stat.AllRideTotal.MovingTime) : "");
                }
            }
            return View(viewModel);
        }
    }
}