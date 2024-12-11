using CarBook1.Application.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
    }
}
