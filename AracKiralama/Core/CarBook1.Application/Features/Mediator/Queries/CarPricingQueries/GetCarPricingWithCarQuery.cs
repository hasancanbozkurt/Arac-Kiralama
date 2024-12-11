using CarBook1.Application.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResult>>
    {
    }
}
