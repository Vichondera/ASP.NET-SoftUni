using All4Auto.Core.Models.Vehicles;

namespace All4Auto.Core.ViewModels
{
    public class AllMakesQueryModel
    {
        public IEnumerable<MakeServiceModel> Makes { get; set; } = Enumerable.Empty<MakeServiceModel>();
    }
}
