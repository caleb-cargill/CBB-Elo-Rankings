using System;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public static class Common
	{

        public static async Task<T> GetRequest<T>(string args)
		{
			try
			{
				string request = DataContext.SearchString(args);
				using (HttpResponseMessage response = await DataContext.ApiClient.GetAsync(request))
				{
					if (response.IsSuccessStatusCode)
					{
						string results = await response.Content.ReadAsStringAsync();

						T root = JsonConvert.DeserializeObject<T>(results);

						return root;
					}
					else
					{
						throw new Exception($"Exception processing get request. Request: {request}. Reason: {response.ReasonPhrase}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return default(T);
			}
		}
	}
}

