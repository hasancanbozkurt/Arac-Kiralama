using CarBook1.Application.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.ReviewQueries
{
    public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
    {
        public int Id { get; set; }

        public GetReviewByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}

