﻿using CarBook1.Application.Features.CQRS.Commands.BannerCommands;
using CarBook1.Application.Interfaces;
using CarBook1.Domain.Entities;

namespace CarBook1.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;
        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoUrl = command.VideoUrl;
            values.VideoDescription = command.VideoDescription;
            await _repository.UpdateAsync(values);
        }
    }
}
