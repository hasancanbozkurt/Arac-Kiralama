using CarBook1.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}
