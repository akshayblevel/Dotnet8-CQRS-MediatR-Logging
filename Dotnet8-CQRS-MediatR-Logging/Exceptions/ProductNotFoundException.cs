using BuildingBlocks.Exceptions;

namespace Dotnet8_CQRS_MediatR_Logging.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid Id) : base("Product", Id)
        {
        }
    }
}
