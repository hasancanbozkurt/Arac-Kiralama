using CarBook1.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWitAuthorsQueryResult>>
    {
    }
}
