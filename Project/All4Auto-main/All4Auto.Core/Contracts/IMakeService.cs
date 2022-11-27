using All4Auto.Core.Models.Vehicles;
using All4Auto.Core.ViewModels;

namespace All4Auto.Core.Contracts
{
    public interface IMakeService
    {
        // Task<int> Create(MakeModel model, int agentId);

        Task<MakeQueryModel> All();

    }
}
