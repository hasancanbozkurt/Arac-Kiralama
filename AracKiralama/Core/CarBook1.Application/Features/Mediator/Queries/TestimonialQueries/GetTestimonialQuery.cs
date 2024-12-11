using CarBook1.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
