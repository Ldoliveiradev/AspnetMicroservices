using AspnetMicroservices.Catalog.API.Entities;
using MongoDB.Driver;

namespace AspnetMicroservices.Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
