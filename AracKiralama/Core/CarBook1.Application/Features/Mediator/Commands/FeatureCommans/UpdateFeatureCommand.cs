using MediatR;

namespace CarBook1.Application.Features.Mediator.Commands.FeatureCommans
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
