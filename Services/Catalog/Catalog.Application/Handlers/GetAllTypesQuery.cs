using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Handlers
{
    public record GetAllTypesQuery: IRequest<IList<TypesResponse>>
    {
    }
}
