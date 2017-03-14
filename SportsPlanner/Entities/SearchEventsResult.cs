using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsPlanner.Entities
{
	public class SearchEventsResult
	{
		[JsonProperty("events")]
		public IList<Event> Events { get; set; }

		[JsonProperty("details")]
		public SearchEventsDetails Details { get; set; }
	}
}
