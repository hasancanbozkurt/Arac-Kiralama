using CarBook1.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}
