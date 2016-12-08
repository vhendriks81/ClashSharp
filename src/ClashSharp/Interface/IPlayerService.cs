using ClashSharp.Data;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IPlayerService
    {
        Task<PlayerInformation> GetPlayerInformation(string playerTag);
    }
}
