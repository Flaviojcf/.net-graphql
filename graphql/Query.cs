using Domain.Models;
using TransferPay.Data.Context;

namespace Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SuperHeroi> GetSuperherois([Service] MyDbContext context) =>
        context.SuperHerois;
    }
}
