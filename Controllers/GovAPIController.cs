using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using KoolExplorer.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoolExplorer.Controllers
{
    public class GovAPIController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

            var msg = await stringTask;
            Console.Write(msg);
        }

        //API: Enrolment - MOE Kindergartens
        public async Task<String> EnrolmentMOEKindergartens()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            string url = "https://data.gov.sg/api/action/datastore_search?resource_id=4ad866a7-c43a-4645-87fd-fc961c9de78a&limit=5";
            var stringTask = client.GetStringAsync(url);

            var msg = await stringTask;
            var jsonModel = JsonSerializer.Deserialize<MOEEnrolment_raw>(msg);
            Console.Write(msg);
            return "";
        }


        public async Task<String> NetEnrolmentRatio()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            string url = "https://data.gov.sg/api/action/datastore_search?resource_id=7b184af5-b718-4c93-b217-c3bb3ab304f4&limit=5";
            var stringTask = client.GetStringAsync(url);

            var msg = await stringTask;
            var jsonModel = JsonSerializer.Deserialize<EnrolmentRate_raw>(msg);
            Console.Write(msg);
            return "";
        }

        //ListingOfCentres
        public async Task<String> ListingOfCentreService()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            string url = "https://data.gov.sg/api/action/datastore_search?resource_id=53a18f6c-1032-44eb-af44-d9babb41d9ef&limit=5";
            var stringTask = client.GetStringAsync(url);

            var msg = await stringTask;
            var jsonModel = JsonSerializer.Deserialize<CentreServices_raw>(msg);
            Console.Write(msg);
            return "";
        }
    }
}
