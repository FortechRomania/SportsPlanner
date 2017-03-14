using Newtonsoft.Json;

namespace SportsPlanner.Entities
{
	public class SearchEventsDetails
	{
		[JsonProperty("total")]
		public string Total { get; set; }

		[JsonProperty("snippets")]
		public string Snippets { get; set; }
	}
}
