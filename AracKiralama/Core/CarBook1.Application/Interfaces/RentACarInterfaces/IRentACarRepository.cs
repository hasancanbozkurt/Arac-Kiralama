using System.Linq.Expressions;
using CarBook1.Domain.Entities;

namespace CarBook1.Application.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
    }
}
