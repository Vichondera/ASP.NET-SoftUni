namespace All4Auto.Core.Services
{
    using All4Auto.Core.Constants;
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Models.Vehicles;
    using All4Auto.Core.ViewModels;
    using All4Auto.DataProcessor.Common;
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class MakeService : IMakeService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        public MakeService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
        }

        public async Task<AllMakesQueryModel> All()
        {
            var result = new AllMakesQueryModel();

            var makes = repo.AllReadOnly<Make>();

            if(!makes.Any())
            {
                throw new ArgumentException("No Records in Db");
            }

            result.Makes = await makes.Select(x=> new Make() 
            {
                Id= x.Id,
                Name= x.Name,
                Models= x.Models,
            }).ToListAsync();

            return result;


        }
    }
}