namespace All4Auto.Core.Services
{
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Models.Vehicle;
    using All4Auto.DataProcessor.Common;
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    public class VehicleService : IVehicleService
    {
        private readonly IRepository repo;

        public VehicleService(IRepository _repo) 
        {
            repo= _repo;
        }
        public async Task<IEnumerable<CarBrandView>> GetAllBrands()
        => await repo.AllReadonly<CarBrand>()
            .OrderBy(b => b.Name)
            .Select(x => new CarBrandView()
            {
               Id= x.Id,
               Name= x.Name,
               Models= x.Models
            })
            .ToListAsync();

        public async Task<IEnumerable<CarBrandView>> GetBrandById(int id)
        {
            var brand = await repo.AllReadonly<CarBrand>()
                .Where(b=>b.Id == id)
                 .Select(x => new CarBrandView()
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Models = x.Models
                 }).ToListAsync();

            return brand;
        }
    }
}
