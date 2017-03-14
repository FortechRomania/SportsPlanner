using Newtonsoft.Json;

namespace SportsPlanner.Entities
{
	public class Event
	{
		[JsonProperty("no")]
		public string No { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("parent_category")]
		public string ParentCategory { get; set; }

		[JsonProperty("venue")]
		public string Venue { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("startdate")]
		public string Startdate { get; set; }

		[JsonProperty("enddate")]
		public string Enddate { get; set; }

		[JsonProperty("alias")]
		public string Alias { get; set; }

		[JsonProperty("venuealias")]
		public string Venuealias { get; set; }

		[JsonProperty("lat")]
		public string Lat { get; set; }

		[JsonProperty("lon")]
		public string Lon { get; set; }

		[JsonProperty("user")]
		public string User { get; set; }

		[JsonProperty("createdby")]
		public string Createdby { get; set; }

		[JsonProperty("rating")]
		public string Rating { get; set; }
	}
}