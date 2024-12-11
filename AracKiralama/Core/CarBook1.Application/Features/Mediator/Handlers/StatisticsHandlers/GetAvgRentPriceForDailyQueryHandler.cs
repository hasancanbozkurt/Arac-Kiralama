﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook1.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook1.Application.Features.Mediator.Results.StatisticsResults;
using CarBook1.Application.Interfaces.StatisticsInterfaces;

namespace CarBook1.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    internal class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForDailyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDaily();
            return new GetAvgRentPriceForDailyQueryResult
            {
                AvgPriceForDaily = value
            };
        }
    }
}