namespace All4Auto.Core.Services
{
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Models.Catalog;

    using All4Auto.DataProcessor.Common;
    using All4Auto.DataProcessor.Models.Vehicles;

    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class MakeService : IMakeService
    {
        private readonly IRepository repo;

        public MakeService(IRepository _repo)
        {
            repo= _repo;
        }

        public async Task<IEnumerable<MakeViewModel>> GetAllMakes()
        {
           return await repo.AllReadonly<Make>()
                .OrderBy(x => x.Name)
                .Select(m => new MakeViewModel()
                { 
                    Name= m.Name,
                    Models = m.Models
                }).ToListAsync();
        }

        public async Task<IEnumerable<ModelView>> GetMakeModelsById(int id)
        {
            return await repo.AllReadonly<Model>()
                .Where(x=>x.Id == id)
                .Select(m => new ModelView()
                {
                   

                }).ToListAsync();
        }

    }
}
