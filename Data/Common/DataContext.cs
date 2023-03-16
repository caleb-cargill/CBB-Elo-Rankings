using System;
using System.Net;
using System.Net.Http.Headers;

namespace CBB_Elo_Ratings.Data
{
	public class DataContext
	{
        private static string Endpoint = @"https://api.sportsdata.io/v3/cbb/scores/json/";
        private static string AccessKey = "";
        public static HttpClient ApiClient { get; set; }

        static DataContext()
		{
            if (ApiClient == null)
            {
                ApiClient = new HttpClient();
                ApiClient.BaseAddress = new Uri(Endpoint);
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static string SearchString(string args)
            => args + AccessKey;
	}
}

