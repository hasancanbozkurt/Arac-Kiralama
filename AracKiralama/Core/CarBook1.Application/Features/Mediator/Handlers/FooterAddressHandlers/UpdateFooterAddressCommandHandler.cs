﻿using CarBook1.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook1.Application.Interfaces;
using CarBook1.Domain.Entities;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAddressID);
            values.Phone = request.Phone;
            values.Address = request.Address;
            values.Description = request.Description;
            values.Email = request.Email;
            await _repository.UpdateAsync(values);
        }
    }
}
