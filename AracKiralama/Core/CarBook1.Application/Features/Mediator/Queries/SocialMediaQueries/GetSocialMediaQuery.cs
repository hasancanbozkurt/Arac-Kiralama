using CarBook1.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
