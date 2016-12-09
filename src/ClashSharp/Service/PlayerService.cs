using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using System.Threading.Tasks;

namespace ClashSharp.Service
{
    public class PlayerService : ServiceBase, IPlayerService
    {
        private ITagService _tagSvc = new TagService();

        public async Task<PlayerInformation> GetPlayerInformation(string playerTag)
        {
            var encodedClanTag = _tagSvc.EncodeTag(playerTag);
            var url = string.Format(UrlConstants.GetPlayerInformationUrlTemplate, encodedClanTag);

            var result = await _apiClient.Get<PlayerInformation>(url);
            return result;
        }
    }
}
