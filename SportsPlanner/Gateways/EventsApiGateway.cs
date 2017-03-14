using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SportsPlanner.Entities;

namespace SportsPlanner.Gateways
{
	public class EventsApiGateway: IEventsGateway
	{
		public async Task<SearchEventsResult> GetEventsAsync()
		{
			var httpClient = new HttpClient();

			// TODO - Change this method to receive the search query parameters and remove the  hardcoded url
			var url = "https://sportsplanner.com/custom/bootstrap_search_home/get_events.php?cat=0&dat=all&lat=49.4562193&ln=ro-RO&loc=DE&lon=11.0935726&r=100%0a";
			try
			{
				var response = await httpClient.GetAsync(url);
				var json = await response.Content.ReadAsStringAsync();
				var searchEventsResult = JsonConvert.DeserializeObject<SearchEventsResult>(json);

				return searchEventsResult;
			}
			finally
			{
				// TODO - Catch the exception and throw an application specific exception
				httpClient.Dispose();
			}
		}
	}
}
