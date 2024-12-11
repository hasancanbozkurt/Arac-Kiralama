using System.Linq.Expressions;
using CarBook1.Application.Interfaces.RentACarInterfaces;
using CarBook1.Domain.Entities;
using CarBook1.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook1.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;
        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }
        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
            return values;
        }
    }
}
