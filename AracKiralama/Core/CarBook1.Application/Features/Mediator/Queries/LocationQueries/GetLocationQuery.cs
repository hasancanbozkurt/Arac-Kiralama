using CarBook1.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
