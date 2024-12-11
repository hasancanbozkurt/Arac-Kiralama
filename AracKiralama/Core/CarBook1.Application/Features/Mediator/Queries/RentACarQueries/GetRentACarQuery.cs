using CarBook1.Application.Features.Mediator.Results.RentACarResults;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationID { get; set; }
        public bool Available { get; set; }
    }
}
