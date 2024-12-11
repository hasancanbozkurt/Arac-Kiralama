﻿using CarBook1.Application.Features.Mediator.Commands.BlogCommands;
using CarBook1.Application.Interfaces;
using CarBook1.Domain.Entities;
using MediatR;

namespace CarBook1.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public UpdatePricingCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogID);
            values.AuthorID = request.AuthorID;
            values.CreatedDate = request.CreatedDate;
            values.CategoryID = request.CategoryID;
            values.CoverImageUrl = request.CoverImageUrl;
            values.Title = request.Title;
            await _repository.UpdateAsync(values);
        }
    }
}
