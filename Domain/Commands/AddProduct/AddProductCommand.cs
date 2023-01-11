using MediatR;

namespace Domain.Commands.AddProduct;

public class AddProductCommand : IRequest<bool>
{
    public AddProductCommand(string productName, string description)
    {
        ProductName = productName;
        Description = description;
    }

    public string ProductName { get; set; }
    public string Description { get; set; }
}
