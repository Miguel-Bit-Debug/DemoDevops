using MediatR;

namespace Domain.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, bool>
    {
        public async Task<bool> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            // implementar repository

            return true;
        }
    }
}
