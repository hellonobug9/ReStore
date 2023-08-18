using API.Entities;
using SQLitePCL;

namespace API.Extensions;

public static class ProductExtensions
{
    public static IQueryable<Product> Sort(this IQueryable<Product> query, string orderBy)
    {
        if (string.IsNullOrEmpty(orderBy)) return query.OrderBy(p => p.Name);
        query = orderBy switch
        {
            "name" => query.OrderBy(p => p.Name),
            "price" => query.OrderBy(p => p.Price),
            _ => query.OrderBy(p => p.Name)
        };
        return query;
    }
}