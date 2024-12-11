using CarBook1.Application.Features.Mediator.Commands.LocationCommands;
using CarBook1.Application.Interfaces;
using CarBook1.Domain.Entities;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        public CreatePricingCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Location
            {
                Name = request.Name
            });
        }
    }
}
