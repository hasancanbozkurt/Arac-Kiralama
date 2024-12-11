using CarBook1.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {

    }
}
