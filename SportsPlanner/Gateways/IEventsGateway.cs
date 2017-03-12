using SportsPlanner.Entities;
using System.Threading.Tasks;

namespace SportsPlanner.Gateways
{
	public interface IEventsGateway
	{
		Task<SearchEventsResult> GetEventsAsync();
	}
}
