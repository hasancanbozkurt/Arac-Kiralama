using CarBook1.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
    {
    }
}
