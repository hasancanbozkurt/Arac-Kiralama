using CarBook1.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
