using CarBook1.Application.Interfaces.CarDescriptionInterfaces;
using CarBook1.Domain.Entities;
using CarBook1.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook1.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        async Task<CarDescription> ICarDescriptionRepository.GetCarDescription(int carId)
        {
            var values = await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
            return values;
        }
    }
}
