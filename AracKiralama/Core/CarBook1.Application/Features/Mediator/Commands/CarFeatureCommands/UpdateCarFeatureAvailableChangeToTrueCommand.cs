﻿using MediatR;

namespace CarBook1.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToTrueCommand : IRequest
    {
        public int Id { get; set; }

        public UpdateCarFeatureAvailableChangeToTrueCommand(int id)
        {
            Id = id;
        }
    }
}
