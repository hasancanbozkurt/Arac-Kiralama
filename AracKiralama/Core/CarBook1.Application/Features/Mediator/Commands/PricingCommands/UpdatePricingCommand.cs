using MediatR;

namespace CarBook1.Application.Features.Mediator.Commands.PricingCommands
{
    public class UpdatePricingCommand : IRequest
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}
