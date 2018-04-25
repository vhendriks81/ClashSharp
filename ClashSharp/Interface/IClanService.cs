using ClashSharp.Data;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IClanService
    {
        Task<SearchClanResponse> SearchClans(ClanSearchCriteria criteria);
        Task<ClanInformation> GetClanInformation(string clanTag);
        Task<ListClanMembersResponse> ListClanMembers(string clanTag);
        Task<CurrentWarResponse> RetrieveInformationAboutClansCurrentWar(string clanTag);
    }
}
