using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using System.Threading.Tasks;

namespace ClashSharp.Service
{
    public class ClanService : ServiceBase, IClanService
    {
        private ITagService _tagSvc = new TagService();

        public async Task<ClanInformation> GetClanInformation(string clanTag)
        {
            var encodedClanTag = _tagSvc.EncodeTag(clanTag);
            var url = string.Format(UrlConstants.GetClanInformationUrlTemplate, encodedClanTag);

            var result = await _apiClient.Get<ClanInformation>(url);
            return result;
        }

        public async Task<ListClanMembersResponse> ListClanMembers(string clanTag)
        {
            var encodedClanTag = _tagSvc.EncodeTag(clanTag);
            var url = string.Format(UrlConstants.ListClanMembersUrlTemplate, encodedClanTag);

            var result = await _apiClient.Get<ListClanMembersResponse>(url);
            return result;
        }

        public async Task<CurrentWarResponse> RetrieveInformationAboutClansCurrentWar(string clanTag)
        {
            var encodedClanTag = _tagSvc.EncodeTag(clanTag);
            var url = string.Format(UrlConstants.RetrieveInformationAboutClansCurrentWarUrlTemplate, encodedClanTag);

            var result = await _apiClient.Get<CurrentWarResponse>(url);
            return result;
        }

        public async Task<SearchClanResponse> SearchClans(ClanSearchCriteria criteria)
        {
            IClanSearchCriteriaService criteriaSvc = new ClanSearchCriteriaService();

            var queryString = criteriaSvc.BuildQueryStringFromCriteria(criteria);
            var url = string.Format(UrlConstants.SearchClansUrlTemplate, queryString);

            var result = await _apiClient.Get<SearchClanResponse>(url);
            return result;
        }
    }
}
