using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook1.Application.Features.Mediator.Results.StatisticsResults;

namespace CarBook1.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetBrandNameByMaxCarQuery:IRequest<GetBrandNameByMaxCarQueryResult>
    {
    }
}
