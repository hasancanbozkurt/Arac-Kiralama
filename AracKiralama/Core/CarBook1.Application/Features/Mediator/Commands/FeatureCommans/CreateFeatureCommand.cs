using MediatR;

namespace CarBook1.Application.Features.Mediator.Commands.FeatureCommans
{
    public class CreateFeatureCommand : IRequest
    {
        public string Name { get; set; }
    }
}
