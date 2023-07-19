using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext _dbContext;
        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CoffeeShopModel>> List()
        {
            var list = await _dbContext.CoffeeShops.ToListAsync();
            return JsonConvert.DeserializeObject<List<CoffeeShopModel>>(JsonConvert.SerializeObject(list));
        }
    }
}
