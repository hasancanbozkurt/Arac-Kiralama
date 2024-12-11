using MediatR;

namespace CarBook1.Application.Features.Mediator.Commands.FeatureCommans
{
    public class RemoveFeatureCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
